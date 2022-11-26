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

namespace Presentacion_GUI
{
    public partial class FrmClientes : Form
    {
        DataTable Tabla;
        NuevasFuncionesCliente funcionesCliente = new NuevasFuncionesCliente(); 
        public FrmClientes()
        {
            InitializeComponent();
        }

        public struct Datos
        {
            public int ID;
            public String Cedula;
            public String Nombre;
            public String Apellido;
            public String Telefono;
            public String Correo;
            public NEstado Estado;
        }

        public void EditarCliente(NCliente cliente)
        {
            
            Datos informacion;
            informacion.ID = cliente.ID;
            informacion.Cedula = cliente.Cedula;
            informacion.Nombre = cliente.Nombre;
            informacion.Apellido = cliente.Apellido;
            informacion.Telefono = cliente.Telefono;
            informacion.Correo = cliente.Correo;
            informacion.Estado = cliente.PEstado;
            FrmEditarCliente frmEditar = new FrmEditarCliente(informacion); 
            frmEditar.ShowDialog();
        }
        
        public void CargarGrilla()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Cedula");
            Tabla.Columns.Add("Primer Nombre");
            Tabla.Columns.Add("Segundo Nombre");
            Tabla.Columns.Add("Correo");
            Tabla.Columns.Add("Telefono");
            Tabla.Columns.Add("Estado");

            foreach (NCliente item in funcionesCliente.Listar())
            {
                Tabla.Rows.Add(item.Cedula,item.Nombre,item.Apellido,item.Correo,item.Telefono,item.PEstado.Descripcion);   
            }
            GrillaClientes.DataSource = Tabla;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {

            DataView Dv = Tabla.DefaultView;

            switch (cmbTipoBusqueda.Text)
            {
                case "Cedula":
                    Dv.RowFilter = " Cedula LIKE '%" + textBusqueda.Text + "%'";
                    GrillaClientes.DataSource = Dv;
                    break;

                case "Nombre":
                    Dv.RowFilter = " Primer Nombre  LIKE '%" + textBusqueda.Text + "%'";
                    GrillaClientes.DataSource = Dv;
                    break;
                case "Estado":
                    Dv.RowFilter = " Estado  LIKE '%" + textBusqueda.Text + "%'";
                    GrillaClientes.DataSource = Dv;
                    break;
            }
        }

        private void GrillaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.GrillaClientes.Columns[e.ColumnIndex].Index == 0)
            {
                if (funcionesCliente.Listar().Count != 0)
                {
                    EditarCliente(funcionesCliente.Listar()[e.RowIndex]);
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No hay productos guardados");
                }
            }
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

                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                decimal total = 0;
                foreach (var item in funcionesCliente.Listar())
                {
                    filas += "<tr>";
                    filas += "<td>" + item.Cedula.ToString() + "</td>";
                    filas += "<td>" + item.Nombre.ToString() + "</td>";
                    filas += "<td>" + item.Apellido.ToString() + "</td>";
                    filas += "<td>" + item.Correo.ToString() + "</td>";
                    filas += "<td>" + item.Telefono.ToString() + "</td>";
                    filas += "<td>" + item.PEstado.Descripcion.ToString() + "</td>";
                    filas += "</tr>";
                    
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
    }
}
