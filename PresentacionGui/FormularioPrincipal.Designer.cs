namespace PresentacionGui
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconoFormularioHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneSubMenuAdmin = new System.Windows.Forms.Panel();
            this.BtnPersonal = new FontAwesome.Sharp.IconButton();
            this.btnBodega = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnAdministrador = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijoActual)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneSubMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.iconoFormularioHijoActual);
            this.panel3.Location = new System.Drawing.Point(249, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 61);
            this.panel3.TabIndex = 6;
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
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContenedor.Location = new System.Drawing.Point(249, 57);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1214, 621);
            this.PanelContenedor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.paneSubMenuAdmin);
            this.panel1.Controls.Add(this.btnAdministrador);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Location = new System.Drawing.Point(-1, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 556);
            this.panel1.TabIndex = 4;
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
            this.paneSubMenuAdmin.Size = new System.Drawing.Size(251, 200);
            this.paneSubMenuAdmin.TabIndex = 5;
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.ForeColor = System.Drawing.Color.Azure;
            this.BtnPersonal.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.BtnPersonal.IconColor = System.Drawing.Color.Azure;
            this.BtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPersonal.IconSize = 32;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 120);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPersonal.Size = new System.Drawing.Size(251, 54);
            this.BtnPersonal.TabIndex = 6;
            this.BtnPersonal.Text = "   Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnBodega
            // 
            this.btnBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBodega.FlatAppearance.BorderSize = 0;
            this.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodega.ForeColor = System.Drawing.Color.Azure;
            this.btnBodega.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnBodega.IconColor = System.Drawing.Color.Azure;
            this.btnBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBodega.IconSize = 32;
            this.btnBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBodega.Location = new System.Drawing.Point(0, 60);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBodega.Size = new System.Drawing.Size(251, 60);
            this.btnBodega.TabIndex = 5;
            this.btnBodega.Text = "    Bodega";
            this.btnBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBodega.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.Azure;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnProductos.IconColor = System.Drawing.Color.Azure;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 32;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductos.Size = new System.Drawing.Size(251, 60);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
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
            this.btnAdministrador.Size = new System.Drawing.Size(251, 67);
            this.btnAdministrador.TabIndex = 4;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrador.UseVisualStyleBackColor = true;
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
            this.btnEmpleado.Size = new System.Drawing.Size(251, 70);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 131;
            this.iconPictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(251, 131);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 680);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijoActual)).EndInit();
            this.panel1.ResumeLayout(false);
            this.paneSubMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijoActual;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneSubMenuAdmin;
        private FontAwesome.Sharp.IconButton BtnPersonal;
        private FontAwesome.Sharp.IconButton btnBodega;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnAdministrador;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}