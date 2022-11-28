using Entidades;
using Logica;
using Presentacion_GUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }
        #region MOVIMIENTO DE LA PAGINA
        NuevasFuncionEstado funcionEstado = new NuevasFuncionEstado(); 
        NuevasFuncionesCliente funcionesCliente = new NuevasFuncionesCliente();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmEditarEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public FrmEditarCliente(FrmClientes.Datos informacion)
        {
            InitializeComponent();
            CargarLisBoxEstado();

            txtCedulaEditar.Text = informacion.Cedula;
            txtNombreEditar.Text = informacion.Nombre;
            txtApellidoEditar.Text = informacion.Apellido;
            txtTelefonoEditar.Text = informacion.Telefono;
            txtCorreoEditar.Text = informacion.Correo;
            cmbEstadoEdit.Text = informacion.Estado.Descripcion;
            textBoxClienteEditar.Text = informacion.ID.ToString();
        }

        public void Actualizar()
        {
            String Mensaje = String.Empty;
            NCliente obj = new NCliente()
            {
                ID = int.Parse(textBoxClienteEditar.Text),
                Cedula = txtCedulaEditar.Text,
                Nombre = txtNombreEditar.Text,
                Apellido = txtApellidoEditar.Text,
                Telefono = txtTelefonoEditar.Text,
                Correo = txtCorreoEditar.Text,
                PEstado = new NEstado { IdEstado = (int)(((OpcionesCombo)cmbEstadoEdit.SelectedItem).Valor) }

            };
            int IdGenerado = funcionesCliente.Editar(obj, out Mensaje);
            if (IdGenerado == 0)
            {
                MessageBox.Show(Mensaje);
            }
            else
            {
                MessageBox.Show("Cliente actualizado con exito");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            switch (Vacio())
            {
                case true:

                    MessageBox.Show("Debe llenar todos los campos", "Advertencia.", MessageBoxButtons.OK);
                    break;

                case false:
                    Actualizar();
                    this.Close();

                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region VALIDACIONES
        public Boolean Vacio()
        {
            if (txtCedulaEditar.Text == "" || txtNombreEditar.Text == "" || txtApellidoEditar.Text == "" || txtTelefonoEditar.Text == "" ||
                txtCorreoEditar.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtCedulaEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtCedulaEditar.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtNombreEditar.Focus();
                }
            }
        }

        private void txtNombreEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombreEditar.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombreEditar.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtApellidoEditar.Focus();
                }
            }
        }

        private void txtApellidoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtApellidoEditar.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtApellidoEditar.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtTelefonoEditar.Focus();
                }
            }
        }

        private void txtTelefonoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefonoEditar.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtCorreoEditar.Focus();
                }
            }
        }

        private void txtCorreoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (!txtCorreoEditar.Text.Contains("@"))
                {
                    MessageBox.Show("La direccion no contiene el caracter @ ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreoEditar.Text = "";
                    txtCorreoEditar.Focus();
                }
                else
                {
                    btnGuardarCambios.PerformClick();
                }
            }
        }
        #endregion
       
        private void CargarLisBoxEstado()
        {
            List<NEstado> listaEstados = funcionEstado.Listar();
            foreach (NEstado item in listaEstados)
            {
                cmbEstadoEdit.Items.Add(new OpcionesCombo() { Valor = item.IdEstado, Texto = item.Descripcion });
            }
            cmbEstadoEdit.SelectedIndex = 0;
            cmbEstadoEdit.DisplayMember = "Texto";
            cmbEstadoEdit.ValueMember = "Valor";
        }
    }
}
