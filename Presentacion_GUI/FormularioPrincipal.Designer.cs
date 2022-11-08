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
            this.BtnPersonal = new FontAwesome.Sharp.IconButton();
            this.btnBodega = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnAdministrador = new FontAwesome.Sharp.IconButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.iconoFormularioHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.paneSubMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijoActual)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Location = new System.Drawing.Point(-1, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(242, 131);
            this.panelLogo.TabIndex = 3;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // paneSubMenuAdmin
            // 
            this.paneSubMenuAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.paneSubMenuAdmin.Controls.Add(this.BtnPersonal);
            this.paneSubMenuAdmin.Controls.Add(this.btnBodega);
            this.paneSubMenuAdmin.Controls.Add(this.btnProductos);
            this.paneSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSubMenuAdmin.Location = new System.Drawing.Point(0, 137);
            this.paneSubMenuAdmin.Name = "paneSubMenuAdmin";
            this.paneSubMenuAdmin.Size = new System.Drawing.Size(241, 200);
            this.paneSubMenuAdmin.TabIndex = 5;
            // 
            // BtnPersonal
            // 
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
            // btnAdministrador
            // 
            this.btnAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.ForeColor = System.Drawing.Color.Azure;
            this.btnAdministrador.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdministrador.IconColor = System.Drawing.Color.Azure;
            this.btnAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrador.IconSize = 32;
            this.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.Location = new System.Drawing.Point(0, 70);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdministrador.Size = new System.Drawing.Size(241, 67);
            this.btnAdministrador.TabIndex = 4;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click_1);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContenedor.Location = new System.Drawing.Point(240, 61);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1260, 742);
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
            this.iconoFormularioHijoActual.Location = new System.Drawing.Point(7, 12);
            this.iconoFormularioHijoActual.Name = "iconoFormularioHijoActual";
            this.iconoFormularioHijoActual.Size = new System.Drawing.Size(53, 46);
            this.iconoFormularioHijoActual.TabIndex = 0;
            this.iconoFormularioHijoActual.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelSuperior.Controls.Add(this.iconoFormularioHijoActual);
            this.PanelSuperior.Location = new System.Drawing.Point(240, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1260, 61);
            this.PanelSuperior.TabIndex = 2;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.ForeColor = System.Drawing.Color.Azure;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnEmpleado.IconColor = System.Drawing.Color.Azure;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 32;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(241, 70);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.paneSubMenuAdmin);
            this.panel1.Controls.Add(this.btnAdministrador);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 670);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Azure;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRegresar.IconColor = System.Drawing.Color.Azure;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(0, 600);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegresar.Size = new System.Drawing.Size(241, 70);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Login";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panelLogo);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelContenedor;
        private FontAwesome.Sharp.IconButton btnAdministrador;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel paneSubMenuAdmin;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton BtnPersonal;
        private FontAwesome.Sharp.IconButton btnBodega;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijoActual;
        private System.Windows.Forms.Panel PanelSuperior;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}