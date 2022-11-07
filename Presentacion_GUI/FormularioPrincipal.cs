﻿using FontAwesome.Sharp;
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
    public partial class FormularioPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormularioPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //panelMenu.Controls.Add(leftBorderBtn);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void PersonalizarDiseño()
        {
            //solo para ocultar los submenus 
            paneSubMenuAdmin.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (paneSubMenuAdmin.Visible == true)
            {
                paneSubMenuAdmin.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }


        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon

                iconoFormularioHijoActual.IconChar = currentBtn.IconChar;
                iconoFormularioHijoActual.IconColor = currentBtn.IconColor;
            }
        }


        private void Reiniciar()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconoFormularioHijoActual.IconChar = IconChar.Home;
            iconoFormularioHijoActual.IconColor = currentBtn.IconColor;
            OcultarSubMenu();
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OcultarSubMenu();
        }

        private void btnAdministrador_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            MostrarSubMenu(paneSubMenuAdmin);

        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProductos());
            OcultarSubMenu();
        }

        private void btnBodega_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmVistaProductos());
            OcultarSubMenu();

        }

        private void BtnPersonal_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPersonal());
            OcultarSubMenu();
        }


        private void panelLogo_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
