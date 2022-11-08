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
    public partial class FrmNuevoCliente : Form
    {
        List<Cliente> clientes;
        FuncionesCliente funcionesCliente = new FuncionesCliente();

        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            Cliente cliente = new Cliente();
            cliente.ID = funcionesCliente.GetById().ToString();
            cliente.Cedula = txtCedula.Text;
            cliente.Nombre = txtNombre.Text;    
            cliente.Apellido = txtApellido.Text;    
            cliente.Telefono = txtTelefono.Text;    
            cliente.Correo = txtCorreo.Text;
            var resp = funcionesCliente.Agregar(cliente);

            MessageBox.Show(resp);
        }
    }
}
