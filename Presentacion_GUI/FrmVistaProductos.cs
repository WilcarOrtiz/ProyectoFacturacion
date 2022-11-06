using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Presentacion_GUI
{
    public partial class FrmVistaProductos : Form
    {
        Logica.FuncionesProducto funcionesProductos = new Logica.FuncionesProducto();
        int fila;
        DataTable Tabla;
        public FrmVistaProductos()
        {
            InitializeComponent();
        }

        public struct Datos
        {
            public string Codigo;
            public string ID;
            public string NombreProducto;
            public string Descripcion;
            public int Cantidad;
            public float PrecioC;
            public float PrecioV;
        }
        void VistaParaProductos(Entidades.ProductoComprado Articulo)
        {
            MessageBox.Show(Articulo.NombreProducto);
            Datos informacion;
            informacion.ID = Articulo.ID;
            informacion.Codigo = Articulo.Codigo;
            informacion.NombreProducto = Articulo.NombreProducto;
            informacion.Descripcion = Articulo.Descripcion;
            informacion.Cantidad  = Articulo.Unidades ;
            informacion.PrecioC = Articulo.PrecioC;
            informacion.PrecioV = Articulo.PrecioV;
            FrmProductosEdit FPE = new FrmProductosEdit(informacion);
            FPE.ShowDialog();
        }

        void CargarTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Codigo");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Cantidad");
            Tabla.Columns.Add("$ Compra");
            Tabla.Columns.Add("$ Venta");
            foreach (var item in funcionesProductos.GetAllProductos())
            {
                Tabla.Rows.Add(item.Codigo, item.NombreProducto, item.Unidades, item.PrecioC, item.PrecioV);
            }
            GrillaCatalogo.DataSource = Tabla;
        }
        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = Tabla.DefaultView;
            switch (cmbTipoBusqueda.Text)
            {
                case "Codigo":
                    Dv.RowFilter = " Codigo LIKE '" + textBusqueda.Text + "%'";
                    GrillaCatalogo.DataSource = Dv;
                    break;

                case "Nombre":
                    Dv.RowFilter = " Nombre  LIKE '" + textBusqueda.Text + "%'";
                    GrillaCatalogo.DataSource = Dv;
                    break;
            }
        }
        public void GrillaCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 0)
            {
                String Codigo = GrillaCatalogo.Rows[fila].Cells[2].Value.ToString();
                MessageBox.Show(funcionesProductos.EliminarProducto(funcionesProductos.ObtenerPorCodigo(Codigo)));
                CargarTabla();
            }
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 1)
            {
                VistaParaProductos(funcionesProductos.GetAllProductos()[e.RowIndex]);
                CargarTabla();
            }
        }

        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }





       /// <summary>
       /// //
       /// </summary>
        public void GenerarPDF()
        {
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                string TituloPdf = DateTime.Now.ToString("REPORTE (dd/MM/yyyy)");
                Guardar.FileName = TituloPdf + ".pdf";
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                decimal total = 0;
                foreach (var item in funcionesProductos.GetAllProductos())
                {
                    filas += "<tr>";
                    filas += "<td>" + item.Codigo.ToString() + "</td>";
                    filas += "<td>" + item.NombreProducto.ToString() + "</td>";
                    filas += "<td>" + item.Unidades.ToString() + "</td>";
                    filas += "<td>" + item.PrecioV.ToString() + "</td>";
                    filas += "<td>" + item.PrecioC.ToString() + "</td>";
                    filas += "</tr>";
                    total += funcionesProductos.ValorFinal(item.Unidades,item.PrecioC);
                }
                MessageBox.Show(total.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

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

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                }

            }
        }
    }
}
