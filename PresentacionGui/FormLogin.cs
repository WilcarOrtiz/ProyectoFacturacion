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

namespace PresentacionGui
{
    public partial class FormLogin : Form
    {

        FuncionesUsuario funcionesUsuario = new FuncionesUsuario();
        FormularioPrincipal principal = new FormularioPrincipal();
        public FormLogin()
        {
            InitializeComponent();
            btnErroMessage.Visible = false;
        }

        public void Acceder()
        {
            if (txtContraseña.Text == "" || txtUsuario.Text == "")
            {
                btnErroMessage.Visible = true;
            }
            else
            {
                String Usuario = txtUsuario.Text;
                String Contraseña = txtContraseña.Text;

                if (funcionesUsuario.Login(Usuario, Contraseña) == true)
                {
                    principal.Show();
                    btnErroMessage.Visible = false;
                }
                else
                {
                    MessageBox.Show("Ususario incorrecto");
                }

            }
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {

            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Acceder();
        }
    }
}
