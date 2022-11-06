using Entitades;
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
    public partial class CrudUsuario : Form
    {
        FuncionesUsuario funcionesUsuario = new FuncionesUsuario();
        
        public CrudUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (vacio())
            {
                case true:

                    MessageBox.Show("Debe llenar todos los campos", "VERIFICAR.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;

                    case false:

                    CrearUsuario();
                    Restablecer();

                     break;
                
            }
        }

        public void CrearUsuario()
        {
            FrmPersonal frmPersonal = new FrmPersonal();
            Usuario usuario = new Usuario();
            var empleado = new Empleado();
            empleado = frmPersonal.DatosUsuario();

            usuario.Cedula = empleado.Cedula;
            usuario.Contraseña = txtContraseña.Text;
            usuario.NombreUser = txtUsuario.Text;

            funcionesUsuario.Agregar(usuario);
         
        }

        public Boolean vacio()
        {
            if (txtContraseña.Text=="" || txtContraseña.Text == "Contraseña" || txtUsuario.Text =="" || txtUsuario.Text=="Usuario")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Restablecer()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txtUsuario.TextLength < 5)
                    {
                        MessageBox.Show("La longitud de la contraseña es muy corta...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        btnCrear.Focus();
                    }
                }
            
        }
    }
}
