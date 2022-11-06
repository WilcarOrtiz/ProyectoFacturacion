using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;

namespace Presentacion_GUI
{
    public partial class Login : Form
    {
        FuncionesUsuario funcionesUsuario = new FuncionesUsuario();
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbFoto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Transparent;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Transparent;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        public void Acceder()
        {
            if (txtContraseña.Text == "" || txtUsuario.Text == "" || 
                txtContraseña.Text == "Contraseña" || txtUsuario.Text == "Usuario")
            {
                lbMensageError.Text = "Debe llenar los campos.";
                lbMensageError.Visible = true;
                pbError.Visible = true;
            }
            else
            {
                String Usuario = txtUsuario.Text;
                String Contraseña = txtContraseña.Text;

                if (funcionesUsuario.Login(Usuario, Contraseña) == true)
                {
                    frmPrincipal.Show();
                    
                }
                else
                {
                    MessageBox.Show("Ususario incorrecto");
                }
                
            }
        }

        
    }
}
