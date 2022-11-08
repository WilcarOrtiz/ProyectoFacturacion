using Entidades;
using Logica;
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
    public partial class FrmNuevoCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       
        FuncionesCliente funcionesCliente = new FuncionesCliente();

        public FrmNuevoCliente()
        {
            InitializeComponent();
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

        public void RestablecerCampos()
        {
            txtCedula.Text   = "Cedula";
            txtNombre.Text   = "Nombre";
            txtApellido.Text = "Apellido";
            txtTelefono.Text = "Telefono";
            txtCorreo.Text   = "Correo";
        }

        public Boolean Vacio()
        {
            if (txtCedula.Text==""||txtNombre.Text==""||txtApellido.Text==""||txtTelefono.Text==""||
                txtCorreo.Text=="" || txtCedula.Text == "Cedula" || txtNombre.Text == "Nombre" || 
                txtApellido.Text == "Apellido" ||txtTelefono.Text == "Telefono" || txtCorreo.Text == "Correo")
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
     

        private void FrmNuevoCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtCedula.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //falta la validacion de si existe la cedula 
                    txtNombre.Focus();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombre.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombre.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtApellido.Focus();
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtApellido.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtApellido.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtTelefono.Focus();
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength != 10)
                {
                    MessageBox.Show("Deben ser 10 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtCorreo.Focus();
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (!txtCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("La direccion no contiene el caracter @ ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreo.Text = "";
                    txtCorreo.Focus();
                }
                else
                {
                    btnGuardar.PerformClick();
                }
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text=="Cedula")
            {
                txtCedula.Text = "";
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula";
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text=="Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text=="Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void BtnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            switch (Vacio())
            {
                case true:

                    MessageBox.Show("Debe llenar todos los campos", "Advertencia.", MessageBoxButtons.OK);
                    break;

                case false:

                    Guardar();
                    RestablecerCampos();
                    this.Close();
                    break;
            }
        }
    }
}
