using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion_GUI.Utilidades;
using ClosedXML.Excel;

namespace Presentacion_GUI
{
    public partial class Detalle_Factura : Form
    {
        Logica.NuevasFuncionesDetalles_Factura NuevasFuncionesDetalles_Factura = new Logica.NuevasFuncionesDetalles_Factura();
        public Detalle_Factura()
        {
            InitializeComponent();
        }


        //   #region Primer Tab
        public void RealizarBusqueda()
        {
            NFactura nFactura = NuevasFuncionesDetalles_Factura.ObtenerFacutra(textBoxBuscarFactura.Text.ToString());

            if (nFactura.IdFactura != 0)
            {
                textFechaFacturacion.Text = nFactura.FechaFacturacion.ToShortDateString();
                textCedulaEmpleado.Text = nFactura.empleado.Cedula.ToString();
                textNombreEmpleado.Text = (nFactura.empleado.Nombre + " " + nFactura.empleado.Apellido).ToString();
                textCedulaCliente.Text = nFactura.cliente.Cedula.ToString();
                textNombreCliente.Text = (nFactura.cliente.Nombre + " " + nFactura.cliente.Apellido).ToString();
                DataGrillaProductosDetalleFacutra.Rows.Clear();
                foreach (Detalle_Facturas dv in nFactura.detalle_Facturas)
                {
                    DataGrillaProductosDetalleFacutra.Rows.Add(new object[] { dv.DF_producto.Nombre, dv.DF_PrecioVenta, dv.DF_Cantidad, dv.DF_Subtotal });
                }
                textMontoPago.Text = nFactura.MontoPago.ToString("0.00");
                textDescuento.Text = nFactura.Descuento.ToString("0.00");
                textIva.Text = nFactura.Iva.ToString("0.00");
                textCambio.Text = nFactura.MontoCambio.ToString("0.00");
                textTotal.Text = nFactura.Total.ToString("0.00");

            }

        }
        private void BuscarFactura_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();

        }
        private void Limpiar()
        {
            textBoxBuscarFactura.Focus();
            textBoxBuscarFactura.Text = string.Empty;
            DataGrillaProductosDetalleFacutra.Rows.Clear();
            textBoxBuscarFactura.Text = string.Empty;
            textFechaFacturacion.Text = string.Empty;
            textNombreEmpleado.Text = string.Empty;
            textCedulaCliente.Text = string.Empty;
            textCedulaEmpleado.Text = string.Empty;
            textNombreCliente.Text = string.Empty;
            textMontoPago.Text = string.Empty;
            textDescuento.Text = string.Empty;
            textIva.Text = string.Empty;
            textCambio.Text = string.Empty;
            textTotal.Text = string.Empty;

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }
        public void GenerarPDF()
        {
            if (textBoxBuscarFactura.Text == "")
            {
                MessageBox.Show("No se encontro resultado ..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            {
                string Texto_Html = Properties.Resources.PlantillaReportesFacturaDetalles.ToString();

                Texto_Html = Texto_Html.Replace("@numerodocumento", textBoxBuscarFactura.Text.ToUpper());
                Texto_Html = Texto_Html.Replace("@doccliente", textCedulaCliente.Text.ToUpper());
                Texto_Html = Texto_Html.Replace("@nombrecliente", textNombreCliente.Text.ToUpper());
                Texto_Html = Texto_Html.Replace("@fecharegistro", textFechaFacturacion.Text.ToString());
                Texto_Html = Texto_Html.Replace("@Cedula Empleado", textCedulaEmpleado.Text.ToUpper());
                Texto_Html = Texto_Html.Replace("@NombreEmpleado", textNombreEmpleado.Text.ToUpper());
                Texto_Html = Texto_Html.Replace("@montototal", textTotal.Text.ToString());
                Texto_Html = Texto_Html.Replace("@pagocon", textMontoPago.Text.ToString());
                Texto_Html = Texto_Html.Replace("@Descuento", textDescuento.Text.ToString());
                Texto_Html = Texto_Html.Replace("@Iva", textIva.Text.ToString());
                Texto_Html = Texto_Html.Replace("@cambio", textCambio.Text.ToString());


                string filas = string.Empty;

                foreach (DataGridViewRow item in DataGrillaProductosDetalleFacutra.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + item.Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + item.Cells[1].Value.ToString() + "</td>";
                    filas += "<td>" + item.Cells[2].Value.ToString() + "</td>";
                    filas += "<td>" + item.Cells[3].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                Texto_Html = Texto_Html.Replace("@filas", filas);


                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.FileName = String.Format("Compra_{0}.pdf", textBoxBuscarFactura.Text);
                Guardar.Filter = "pdf Files|*.pdf";
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(Texto_Html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Documento Generado..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }


        //   #endregion





        private void Detalle_Factura_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in DataGrillaReportesFacturas.Columns)
            {
                comboBoxBusqueda.Items.Add(new OpcionesCombo() { Valor = column.Name, Texto = column.HeaderText });
            }
            comboBoxBusqueda.SelectedIndex = 0;
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

        }



        private void btnBuscarPorFechas_Click(object sender, EventArgs e)
        {
            List<ReportesFacturasPorFecha> lista = new List<ReportesFacturasPorFecha>();
            lista = NuevasFuncionesDetalles_Factura.ReportesFacturasPorFechas(dateTimeFechaInicio.Value.ToString(), dateTimeFechaFinal.Value.ToString());

            DataGrillaReportesFacturas.Rows.Clear();

            foreach (ReportesFacturasPorFecha item in lista)
            {
                DataGrillaReportesFacturas.Rows.Add(new object[]
                {
                    item.FecharRegistro,
                    item.NumeroFactura,
                    item.MontoTotal,
                    item.CedulaEmpleado,
                    item.CedulaCliente,
                    item.CodigoProducto,
                    item.NombreProducto,
                    item.DescripcionProducto,
                    item.precioVenta
                });
                CalcularGananciaGenerada();
            }
        }

        private void btnBuscarReportesFiltro_Click(object sender, EventArgs e)
        {
            string ColumnaFiltro = ((OpcionesCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();

            if (DataGrillaReportesFacturas.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in DataGrillaReportesFacturas.Rows)
                {
                    if (item.Cells[ColumnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBoxBusquedaFiltro.Text.Trim().ToUpper()))
                    {
                        item.Visible = true;
                      
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }
                CalcularGananciaGenerada();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusquedaFiltro.Text = String.Empty;
            foreach (DataGridViewRow item in DataGrillaReportesFacturas.Rows)
            {
                item.Visible = true;
            }
            CalcularGananciaGenerada();



        }
        public void LimpiarTab2()
        {
            textBoxBusquedaFiltro.Text = String.Empty;
            DataGrillaReportesFacturas.Rows.Clear();
            dateTimeFechaInicio.Text = DateTime.Now.ToString(); 
            dateTimeFechaFinal.Text = DateTime.Now.ToString();
            textBoxTotalGenerado.Text = String.Empty;   
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

            decimal Suma = 0;


            if (DataGrillaReportesFacturas.Rows.Count < 1)
            {

                MessageBox.Show("No se tiene el registro a guardar..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable dataTable = new DataTable();
                foreach (DataGridViewColumn item in DataGrillaReportesFacturas.Columns)
                {
                    dataTable.Columns.Add(item.HeaderText, typeof(string));
                }


                foreach (DataGridViewRow item in DataGrillaReportesFacturas.Rows)
                {
                    if (item.Visible)
                    {
                        dataTable.Rows.Add(new object[]{ item.Cells[0].Value.ToString(),
                            item.Cells[1].Value.ToString(),
                            item.Cells[2].Value.ToString(),
                            item.Cells[3].Value.ToString(),
                            item.Cells[4].Value.ToString(),
                            item.Cells[5].Value.ToString(),
                            item.Cells[6].Value.ToString(),
                            item.Cells[7].Value.ToString(),
                            item.Cells[8].Value.ToString(),
                    });
                    }
                   
                }
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.FileName = String.Format("ReporteFactura_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                Guardar.Filter = "Excel Files|*.xlsx";
                if (Guardar.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook xLWorkbook = new XLWorkbook();
                        var hoja = xLWorkbook.Worksheets.Add(dataTable, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        xLWorkbook.SaveAs(Guardar.FileName);
                        MessageBox.Show("Reporte de excel guardado correctamente..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Reporte no se pudo guardar el excel..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        throw;
                    }
                }
            }
        }
        public void CalcularGananciaGenerada()
        {
            decimal Suma = 0;
            foreach (DataGridViewRow item in DataGrillaReportesFacturas.Rows)
            {
                if (item.Visible==true)
                {
                    Suma += decimal.Parse(item.Cells[8].Value.ToString());
                }
            }
            textBoxTotalGenerado.Text = Suma.ToString("0.00");
        }

        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {
            GenerarPDF();
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LimpiarTab2();
        }
    }
}

