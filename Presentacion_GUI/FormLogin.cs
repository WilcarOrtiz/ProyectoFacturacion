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
    public partial class FormLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Datos informacion;
        FuncionesUsuario funcionesUsuario = new FuncionesUsuario();
        FormularioPrincipal principal;
        public struct Datos
        {
            public string Cedula;
        }

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

                    informacion.Cedula = txtUsuario.Text;
                    principal= new FormularioPrincipal(informacion);
                    principal.Show();
                    this.Visible = false; 
                    btnErroMessage.Visible = false;
                }
                else
                {
                    MessageBox.Show("Ususario incorrecto");
                }
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
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
            //FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
            //formularioPrincipal.Close();
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
    }
}
