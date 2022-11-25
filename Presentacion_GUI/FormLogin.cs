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
using Entidades;
using System.Diagnostics;

namespace Presentacion_GUI
{
    public partial class FormLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
  
        FuncionesUsuario funcionesUsuario = new FuncionesUsuario();

        Logica.NuevasFuncionesUsuario NuevasFuncionesUsuario = new NuevasFuncionesUsuario(); 
        FormularioPrincipal principal;

        public FormLogin()
        {
            InitializeComponent();
        }

        public void Acceder()
        {
            String Mensaje = String.Empty;
            if (txtContraseña.Text == "" || txtUsuario.Text == "")
            {
                btnErroMessage.Visible = true;
                btnErroMessage.Text = "Debe llenar los campos";
            }
            else
            {
                String Usuario = txtUsuario.Text;
                String Contraseña = txtContraseña.Text;
                int IdGenerado = NuevasFuncionesUsuario.Login(Usuario, Contraseña, out Mensaje);

                if (true)
                {

                }

                if (IdGenerado!=0)
                {
                    Usuario usuario = new Usuario();
                    usuario.ID = IdGenerado;
                    usuario.Cedula = Usuario;
                    usuario.Contraseña = txtContraseña.Text;
                    principal = new FormularioPrincipal(usuario);
                    principal.Show();
                    this.Visible = false;
                    btnErroMessage.Visible = false;
                }
                else
                {
                    btnErroMessage.Visible = true;
                    btnErroMessage.Text = "Usuario o contraseña incorrectos";
                    Restablecer();
                }
            }
        }

        public void Restablecer()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "" ; 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Acceder();      
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();        
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {  
                    txtContraseña.Focus();             
            } 
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                    btnIngresar.PerformClick();        
            }
        }
    }
}
