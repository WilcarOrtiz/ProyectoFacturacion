using System;

namespace Presentacion_GUI
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.paneSubMenuAdmin = new System.Windows.Forms.Panel();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.btnInformacionGeneral = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnPersonal = new FontAwesome.Sharp.IconButton();
            this.btnBodega = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.iconoFormularioHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.label3Usuario = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnAdministrador = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.labelHoras = new System.Windows.Forms.Label();
            this.iconPictureHora = new FontAwesome.Sharp.IconPictureBox();
            this.paneSubMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijoActual)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureHora)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(241, 131);
            this.panelLogo.TabIndex = 3;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // paneSubMenuAdmin
            // 
            this.paneSubMenuAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.paneSubMenuAdmin.Controls.Add(this.BtnClientes);
            this.paneSubMenuAdmin.Controls.Add(this.btnInformacionGeneral);
            this.paneSubMenuAdmin.Controls.Add(this.iconButton1);
            this.paneSubMenuAdmin.Controls.Add(this.BtnPersonal);
            this.paneSubMenuAdmin.Controls.Add(this.btnBodega);
            this.paneSubMenuAdmin.Controls.Add(this.btnProductos);
            this.paneSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSubMenuAdmin.Location = new System.Drawing.Point(0, 203);
            this.paneSubMenuAdmin.Name = "paneSubMenuAdmin";
            this.paneSubMenuAdmin.Size = new System.Drawing.Size(241, 558);
            this.paneSubMenuAdmin.TabIndex = 5;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.ForeColor = System.Drawing.Color.Azure;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.BtnClientes.IconColor = System.Drawing.Color.Azure;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 32;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientes.Location = new System.Drawing.Point(0, 282);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnClientes.Size = new System.Drawing.Size(241, 54);
            this.BtnClientes.TabIndex = 9;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnInformacionGeneral
            // 
            this.btnInformacionGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacionGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacionGeneral.FlatAppearance.BorderSize = 0;
            this.btnInformacionGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionGeneral.ForeColor = System.Drawing.Color.Azure;
            this.btnInformacionGeneral.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnInformacionGeneral.IconColor = System.Drawing.Color.Azure;
            this.btnInformacionGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformacionGeneral.IconSize = 32;
            this.btnInformacionGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformacionGeneral.Location = new System.Drawing.Point(0, 228);
            this.btnInformacionGeneral.Name = "btnInformacionGeneral";
            this.btnInformacionGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInformacionGeneral.Size = new System.Drawing.Size(241, 54);
            this.btnInformacionGeneral.TabIndex = 8;
            this.btnInformacionGeneral.Text = "General";
            this.btnInformacionGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformacionGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformacionGeneral.UseVisualStyleBackColor = true;
            this.btnInformacionGeneral.Click += new System.EventHandler(this.btnInformacionGeneral_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Azure;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconButton1.IconColor = System.Drawing.Color.Azure;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 174);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(241, 54);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Gestiones";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.ForeColor = System.Drawing.Color.Azure;
            this.BtnPersonal.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.BtnPersonal.IconColor = System.Drawing.Color.Azure;
            this.BtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPersonal.IconSize = 32;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 120);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPersonal.Size = new System.Drawing.Size(241, 54);
            this.BtnPersonal.TabIndex = 6;
            this.BtnPersonal.Text = "   Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click_1);
            // 
            // btnBodega
            // 
            this.btnBodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBodega.FlatAppearance.BorderSize = 0;
            this.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodega.ForeColor = System.Drawing.Color.Azure;
            this.btnBodega.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnBodega.IconColor = System.Drawing.Color.Azure;
            this.btnBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBodega.IconSize = 32;
            this.btnBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBodega.Location = new System.Drawing.Point(0, 60);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBodega.Size = new System.Drawing.Size(241, 60);
            this.btnBodega.TabIndex = 5;
            this.btnBodega.Text = "    Bodega";
            this.btnBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBodega.UseVisualStyleBackColor = true;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.Azure;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnProductos.IconColor = System.Drawing.Color.Azure;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 32;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductos.Size = new System.Drawing.Size(241, 60);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelContenedor.Location = new System.Drawing.Point(240, 83);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1441, 726);
            this.PanelContenedor.TabIndex = 1;
            // 
            // iconoFormularioHijoActual
            // 
            this.iconoFormularioHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconoFormularioHijoActual.ForeColor = System.Drawing.Color.Azure;
            this.iconoFormularioHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconoFormularioHijoActual.IconColor = System.Drawing.Color.Azure;
            this.iconoFormularioHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoFormularioHijoActual.IconSize = 46;
            this.iconoFormularioHijoActual.Location = new System.Drawing.Point(29, 12);
            this.iconoFormularioHijoActual.Name = "iconoFormularioHijoActual";
            this.iconoFormularioHijoActual.Size = new System.Drawing.Size(53, 46);
            this.iconoFormularioHijoActual.TabIndex = 0;
            this.iconoFormularioHijoActual.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelSuperior.Controls.Add(this.label3Usuario);
            this.PanelSuperior.Controls.Add(this.textBoxId);
            this.PanelSuperior.Controls.Add(this.textBoxCedula);
            this.PanelSuperior.Controls.Add(this.iconoFormularioHijoActual);
            this.PanelSuperior.Location = new System.Drawing.Point(240, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1441, 77);
            this.PanelSuperior.TabIndex = 2;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // label3Usuario
            // 
            this.label3Usuario.AutoSize = true;
            this.label3Usuario.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Usuario.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3Usuario.Location = new System.Drawing.Point(1110, 24);
            this.label3Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3Usuario.Name = "label3Usuario";
            this.label3Usuario.Size = new System.Drawing.Size(64, 21);
            this.label3Usuario.TabIndex = 60;
            this.label3Usuario.Text = "Usuario";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.White;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.textBoxId.Location = new System.Drawing.Point(1196, 24);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(30, 19);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.BackColor = System.Drawing.Color.White;
            this.textBoxCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCedula.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.textBoxCedula.Location = new System.Drawing.Point(1249, 24);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.ReadOnly = true;
            this.textBoxCedula.Size = new System.Drawing.Size(171, 19);
            this.textBoxCedula.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Controls.Add(this.paneSubMenuAdmin);
            this.panel1.Controls.Add(this.btnAdministrador);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 896);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.ForeColor = System.Drawing.Color.Azure;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnEmpleado.IconColor = System.Drawing.Color.Azure;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 32;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 761);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(241, 55);
            this.btnEmpleado.TabIndex = 9;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.ForeColor = System.Drawing.Color.Azure;
            this.btnAdministrador.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdministrador.IconColor = System.Drawing.Color.Azure;
            this.btnAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrador.IconSize = 32;
            this.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.Location = new System.Drawing.Point(0, 131);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdministrador.Size = new System.Drawing.Size(241, 72);
            this.btnAdministrador.TabIndex = 8;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Azure;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnCerrar.IconColor = System.Drawing.Color.Azure;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 822);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrar.Size = new System.Drawing.Size(241, 74);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Exit";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoras.ForeColor = System.Drawing.Color.Azure;
            this.labelHoras.Location = new System.Drawing.Point(1436, 832);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(0, 37);
            this.labelHoras.TabIndex = 3;
            // 
            // iconPictureHora
            // 
            this.iconPictureHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureHora.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureHora.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconPictureHora.IconColor = System.Drawing.Color.Azure;
            this.iconPictureHora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureHora.IconSize = 38;
            this.iconPictureHora.Location = new System.Drawing.Point(1383, 835);
            this.iconPictureHora.Name = "iconPictureHora";
            this.iconPictureHora.Size = new System.Drawing.Size(50, 38);
            this.iconPictureHora.TabIndex = 4;
            this.iconPictureHora.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1680, 883);
            this.Controls.Add(this.iconPictureHora);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipal";
            this.paneSubMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijoActual)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdministrador_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            label3Usuario.ForeColor = RGBColors.color3;
            labelHoras.ForeColor = RGBColors.color3;
            MostrarSubMenu(paneSubMenuAdmin);
        }

        #endregion
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel paneSubMenuAdmin;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton BtnPersonal;
        private FontAwesome.Sharp.IconButton btnBodega;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijoActual;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label3Usuario;
        private FontAwesome.Sharp.IconButton btnAdministrador;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private System.Windows.Forms.Label labelHoras;
        private FontAwesome.Sharp.IconPictureBox iconPictureHora;
        private FontAwesome.Sharp.IconButton btnInformacionGeneral;
        private FontAwesome.Sharp.IconButton BtnClientes;
    }
}