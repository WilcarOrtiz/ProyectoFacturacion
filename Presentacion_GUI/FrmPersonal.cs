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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
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
                    txtNombres.Focus();
                }
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtNombres.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtNombres.TextLength <= 2)
                {
                    MessageBox.Show("El texto es muy corto...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    txtApellidos.Focus();
                }
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && txtApellidos.TextLength == 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                if (txtApellidos.TextLength <= 2)
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
                    txtContraseña.Focus();
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTelefono.TextLength < 5)
                {
                    MessageBox.Show("La longitud de la contraseña es muy corta...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    pbGuardarPersonal.Focus();
                }
            }
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionCargos();
            txtCedula.Select();
        }

        public void Restablecer()
        {
            txtCedula.Text = "Cedula";
            txtNombres.Text = "Nombres";
            txtApellidos.Text = "Apellidos";
            txtTelefono.Text = "Telefono";
            txtCorreo.Text = "Correo";
            txtContraseña.Text = "Contraseña";
            cmbCargos.SelectedIndex = -1;
        }

        public void SeleccionCargos()
        {
            if (cmbCargos.Text == "")
            {
                BloqueoTextBox();
            }
            else
            {
                DesbloqueoTextBox();

                if (cmbCargos.Text == "VENDEDOR")
                {
                    txtContraseña.Enabled = true;
                }
            }
        }

        public void BloqueoTextBox()
        {
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtCedula.Enabled = false;
            txtContraseña.Enabled = false;
            txtCorreo.Enabled = false;
            txtNombres.Enabled = false;
        }

        public void DesbloqueoTextBox()
        {
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtCedula.Enabled = true;
            txtCorreo.Enabled = true;
            txtNombres.Enabled = true;
            txtContraseña.Enabled = false;
        }

        private void txtCedula_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula")
            {
                txtCedula.Clear();
            }
        }

        private void txtNombres_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Clear();
            }
        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Clear();
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Clear();
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Clear();
            }
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Clear();
            };
        }

        private void pbGuardarPersonal_Click(object sender, EventArgs e)
        {
            switch (vacio())
            {
                case true:
                    MessageBox.Show("Debe llenar todos los campos", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case false:
                    Restablecer();
                    break;
            }
        }

        public Boolean vacio()
        {
            if (txtContraseña.Text == "" || txtCedula.Text == "" || txtApellidos.Text == "" ||
                txtNombres.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                return true;
            }
            return false;
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            SeleccionCargos();
        }
    }
}
