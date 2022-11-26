namespace Presentacion_GUI
{
    partial class FrmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IconoBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.iconPictureNuevoUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.btnGuardarPersonal = new FontAwesome.Sharp.IconButton();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.GrillaEmpleados);
            this.panel1.Controls.Add(this.IconoBuscar);
            this.panel1.Controls.Add(this.textBusqueda);
            this.panel1.Controls.Add(this.cmbTipoBusqueda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(402, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 672);
            this.panel1.TabIndex = 2;
            // 
            // GrillaEmpleados
            // 
            this.GrillaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrillaEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GrillaEmpleados.Location = new System.Drawing.Point(28, 145);
            this.GrillaEmpleados.Name = "GrillaEmpleados";
            this.GrillaEmpleados.RowHeadersWidth = 62;
            this.GrillaEmpleados.RowTemplate.Height = 28;
            this.GrillaEmpleados.Size = new System.Drawing.Size(969, 509);
            this.GrillaEmpleados.TabIndex = 64;
            this.GrillaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpleados_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 71;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Editar";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 57;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.IconoBuscar.ForeColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.IconoBuscar.IconColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBuscar.Location = new System.Drawing.Point(179, 35);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(32, 32);
            this.IconoBuscar.TabIndex = 17;
            this.IconoBuscar.TabStop = false;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(504, 35);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(407, 26);
            this.textBusqueda.TabIndex = 16;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Estado"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(243, 35);
            this.cmbTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(141, 28);
            this.cmbTipoBusqueda.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(24, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Buscar por";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.iconPictureNuevoUsuario);
            this.panel2.Controls.Add(this.btnGuardarPersonal);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtApellidos);
            this.panel2.Controls.Add(this.txtNombres);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Location = new System.Drawing.Point(20, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 669);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(64, 467);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(160, 459);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(136, 28);
            this.cmbEstado.TabIndex = 7;
            // 
            // iconPictureNuevoUsuario
            // 
            this.iconPictureNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureNuevoUsuario.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureNuevoUsuario.IconColor = System.Drawing.Color.Azure;
            this.iconPictureNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureNuevoUsuario.IconSize = 72;
            this.iconPictureNuevoUsuario.Location = new System.Drawing.Point(139, 35);
            this.iconPictureNuevoUsuario.Name = "iconPictureNuevoUsuario";
            this.iconPictureNuevoUsuario.Size = new System.Drawing.Size(75, 72);
            this.iconPictureNuevoUsuario.TabIndex = 64;
            this.iconPictureNuevoUsuario.TabStop = false;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.ForeColor = System.Drawing.Color.Azure;
            this.btnGuardarPersonal.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnGuardarPersonal.IconColor = System.Drawing.Color.Azure;
            this.btnGuardarPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPersonal.IconSize = 32;
            this.btnGuardarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(139, 564);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarPersonal.Size = new System.Drawing.Size(63, 40);
            this.btnGuardarPersonal.TabIndex = 7;
            this.btnGuardarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(68, 398);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(228, 26);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(68, 290);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(228, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(68, 344);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 26);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(68, 241);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 26);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(68, 188);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(228, 26);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Text = "Nombres";
            this.txtNombres.Enter += new System.EventHandler(this.txtNombres_Enter);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            this.txtNombres.Leave += new System.EventHandler(this.txtNombres_Leave);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(68, 135);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 26);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "Cedula";
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1441, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureNuevoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCedula;
        private FontAwesome.Sharp.IconPictureBox IconoBuscar;
        private FontAwesome.Sharp.IconButton btnGuardarPersonal;
        private FontAwesome.Sharp.IconPictureBox iconPictureNuevoUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}