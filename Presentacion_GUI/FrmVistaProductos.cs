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
using Entidades;
using Presentacion_GUI.Utilidades;


namespace Presentacion_GUI
{
    public partial class FrmVistaProductos : Form
    {

        Logica.NuevasFuncionesProductos NuevasFuncionesProductos = new NuevasFuncionesProductos();

        int fila;
        DataTable Tabla;
        public FrmVistaProductos()
        {
            InitializeComponent();

        }

        //Estructuira para pasar informacion entre form
        public struct Datos
        {
         
            public string Codigo;
            public int ID;
            public string NombreProducto;
            public string Descripcion;
            public int Cantidad;
            public decimal PrecioC;
            public decimal PrecioV;
            public NEstado Estado;
            public NCategoria Categoria;
        }
       
        //llenado de la estructura Datos
        void VistaParaProductos(Entidades.NProducto Articulo)
        {
            Datos informacion;
            informacion.ID = Articulo.IdProducto;
            informacion.Codigo = Articulo.Codigo;
            informacion.NombreProducto = Articulo.Nombre;
            informacion.Descripcion = Articulo.Descripcion;
            informacion.Cantidad = Articulo.Stock;
            informacion.PrecioC = Articulo.PrecioCompra;
            informacion.PrecioV = Articulo.PrecioVenta;
            informacion.Categoria = Articulo.PCategoria;
            informacion.Estado = Articulo.PEstado;
            FrmProductosEdit FPE = new FrmProductosEdit(informacion);
            FPE.ShowDialog();
        }

        void CargarTabla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("ID");
            Tabla.Columns.Add("Codigo");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Descripcion");
            Tabla.Columns.Add("Categoria");
            Tabla.Columns.Add("Stock");
            Tabla.Columns.Add("Estado");
            Tabla.Columns.Add("$ Compra");
            Tabla.Columns.Add("$ Venta");
            foreach (NProducto item in NuevasFuncionesProductos.Listar())
            {
                Tabla.Rows.Add(item.IdProducto, item.Codigo, item.Nombre, item.Descripcion, item.PCategoria.Descripcion, item.Stock, item.PEstado.Descripcion, item.PrecioCompra, item.PrecioVenta);
            }
            GrillaCatalogo.DataSource = Tabla;
        }

        //Evento para hacer el filtrado de busqueda
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
                case "Estado":
                    Dv.RowFilter = " Estado  LIKE '" + textBusqueda.Text + "%'";
                    GrillaCatalogo.DataSource = Dv;
                    break;
            }
        }

        //Evento click para eliminar o editar producto
        public void GrillaCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Mensaje = String.Empty;
            fila = e.RowIndex;
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 0)
            {

                NProducto nProducto = new NProducto()
                {
                    IdProducto = Convert.ToInt32(GrillaCatalogo.Rows[fila].Cells[2].Value.ToString()),
                    Codigo = GrillaCatalogo.Rows[fila].Cells[3].Value.ToString(),
                    Nombre = GrillaCatalogo.Rows[fila].Cells[4].Value.ToString(),
                    Descripcion = GrillaCatalogo.Rows[fila].Cells[5].Value.ToString(),
                    PCategoria = new NCategoria { Descripcion = GrillaCatalogo.Rows[fila].Cells[6].Value.ToString() },
                    Stock = Convert.ToInt32(GrillaCatalogo.Rows[fila].Cells[7].Value.ToString()),
                    PEstado = new NEstado { Descripcion= GrillaCatalogo.Rows[fila].Cells[8].Value.ToString() },
                    PrecioCompra = Convert.ToDecimal(GrillaCatalogo.Rows[fila].Cells[9].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(GrillaCatalogo.Rows[fila].Cells[10].Value.ToString())

                };


                int IdGenerado = NuevasFuncionesProductos.Eliminar(nProducto, out Mensaje);
                if (IdGenerado == 0)
                {
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show("Producto desactivado con exito");
                }

                CargarTabla();
            }
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 1)
            {
                if (NuevasFuncionesProductos.Listar().Count != 0)
                {
                    VistaParaProductos(NuevasFuncionesProductos.Listar()[e.RowIndex]);
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("No hay productos guardados");
                }
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
        public void GenerarPDF()
        {
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                string TituloPdf = DateTime.Now.ToString("REPORTE (dd/MM/yyyy)");
                Guardar.FileName = TituloPdf + ".pdf";
                /////////
                Guardar.Filter = "pd Files|*.pdf";
                //////

                string PaginaHTML_Texto = Properties.Resources.Pdf_Plantilla_Catalogo.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                decimal total = 0;
                foreach (var item in NuevasFuncionesProductos.Listar())
                {
                    filas += "<tr>";
                    filas += "<td>" + item.Codigo.ToString() + "</td>";
                    filas += "<td>" + item.Nombre.ToString() + "</td>";
                    filas += "<td>" + item.Stock.ToString() + "</td>";
                    filas += "<td>" + item.PCategoria.Descripcion.ToString() + "</td>";
                    filas += "<td>" + item.PEstado.Descripcion.ToString() + "</td>";
                    filas += "<td>" + item.FechaIngreso.ToShortDateString() + "</td>";
                    filas += "<td>" + item.PrecioVenta.ToString() + "</td>";
                    filas += "<td>" + item.PrecioCompra.ToString() + "</td>";
                    filas += "</tr>";
                    total += NuevasFuncionesProductos.ValorFinal(item.Stock, item.PrecioCompra);
                }
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
