﻿using Logica;
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
        public void GrillaCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            if (this.GrillaCatalogo.Columns[e.ColumnIndex].Index == 0)
            {
                String Codigo = GrillaCatalogo.Rows[fila].Cells[2].Value.ToString();
             //   MessageBox.Show(funcionesProductos.EliminarProducto(funcionesProductos.ObtenerPorCodigo(Codigo)));
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
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            GenerarPDF();
        }
    }
}
