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
    public partial class FrmEditarEmpleado : Form
    {
       
        FuncionesEmpleado funcionesEmpleado = new FuncionesEmpleado(); 
        FrmPersonal FrmPersonal = new FrmPersonal();
        String ID;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmEditarEmpleado(FrmPersonal.Datos informacion)
        {
            InitializeComponent();

            ID = informacion.ID;
            txtCedulaEditar.Text   = informacion.Cedula;
            txtNombreEditar.Text   = informacion.Nombre;
            txtApellidoEditar.Text = informacion.Apellido;
            txtTelefonoEditar.Text = informacion.Telefono;
            txtCorreoEditar.Text   = informacion.Correo;
        }

        public void Actualizar()
        {
            String cedula = funcionesEmpleado.EmpleadoXId(ID);
            Empleado empleado = funcionesEmpleado.ObtenerPorCedula(cedula);
            String IDeditada = funcionesEmpleado.IdXEmpleado(txtCedulaEditar.Text);

            if ((ID == IDeditada)||(funcionesEmpleado.ObtenerPorCedula(txtCedulaEditar.Text)==null))
            {
                MessageBox.Show(funcionesEmpleado.Editar(ID,txtCedulaEditar.Text,txtNombreEditar.Text,txtApellidoEditar.Text,
                    txtTelefonoEditar.Text,txtCorreoEditar.Text,empleado));
            }
            else
            {
                switch (MessageBox.Show("La cedula ya existe \nDesea continuar con la actulizacion", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.OK:
                        txtCedulaEditar.Text = "";
                        txtCedulaEditar.Focus();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }

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
                    //falta la validacion de si existe la cedula 
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

        private void FrmEditarEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
