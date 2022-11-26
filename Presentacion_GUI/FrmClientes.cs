using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
