namespace Presentacion_GUI
{
    partial class FrmEditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarEmpleado));
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtApellidoEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmpleadoEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(113, 120);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.Size = new System.Drawing.Size(269, 26);
            this.txtCedulaEditar.TabIndex = 1;
            this.txtCedulaEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaEditar_KeyPress);
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(113, 348);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtCorreoEditar.TabIndex = 3;
            this.txtCorreoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoEditar_KeyPress);
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(113, 289);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtTelefonoEditar.TabIndex = 4;
            this.txtTelefonoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEditar_KeyPress);
            // 
            // txtApellidoEditar
            // 
            this.txtApellidoEditar.Location = new System.Drawing.Point(113, 229);
            this.txtApellidoEditar.Name = "txtApellidoEditar";
            this.txtApellidoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtApellidoEditar.TabIndex = 5;
            this.txtApellidoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEditar_KeyPress);
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(113, 174);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(269, 26);
            this.txtNombreEditar.TabIndex = 6;
            this.txtNombreEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEditar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.textBoxEmpleadoEditar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEstadoEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreEditar);
            this.panel1.Controls.Add(this.txtApellidoEditar);
            this.panel1.Controls.Add(this.txtTelefonoEditar);
            this.panel1.Controls.Add(this.txtCorreoEditar);
            this.panel1.Controls.Add(this.txtCedulaEditar);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 624);
            this.panel1.TabIndex = 8;
            // 
            // textBoxEmpleadoEditar
            // 
            this.textBoxEmpleadoEditar.Location = new System.Drawing.Point(400, 120);
            this.textBoxEmpleadoEditar.Name = "textBoxEmpleadoEditar";
            this.textBoxEmpleadoEditar.Size = new System.Drawing.Size(29, 26);
            this.textBoxEmpleadoEditar.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Estado";
            // 
            // cmbEstadoEdit
            // 
            this.cmbEstadoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstadoEdit.FormattingEnabled = true;
            this.cmbEstadoEdit.Location = new System.Drawing.Point(223, 416);
            this.cmbEstadoEdit.Name = "cmbEstadoEdit";
            this.cmbEstadoEdit.Size = new System.Drawing.Size(159, 28);
            this.cmbEstadoEdit.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(157, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Empleado";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Azure;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.Azure;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.IconSize = 32;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(65, 492);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarCambios.Size = new System.Drawing.Size(213, 52);
            this.btnGuardarCambios.TabIndex = 80;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Azure;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelar.IconColor = System.Drawing.Color.Azure;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 32;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(284, 498);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(145, 40);
            this.BtnCancelar.TabIndex = 79;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Azure;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(113, 54);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 32);
            this.iconPictureBox1.TabIndex = 81;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 672);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEmpleado";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEditarEmpleado_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtApellidoEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstadoEdit;
        private System.Windows.Forms.TextBox textBoxEmpleadoEditar;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}