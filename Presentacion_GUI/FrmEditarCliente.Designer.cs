namespace Presentacion_GUI
{
    partial class FrmEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxClienteEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.txtApellidoEditar = new System.Windows.Forms.TextBox();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.textBoxClienteEditar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEstadoEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreEditar);
            this.panel1.Controls.Add(this.txtApellidoEditar);
            this.panel1.Controls.Add(this.txtTelefonoEditar);
            this.panel1.Controls.Add(this.txtCorreoEditar);
            this.panel1.Controls.Add(this.txtCedulaEditar);
            this.panel1.Location = new System.Drawing.Point(21, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 606);
            this.panel1.TabIndex = 9;
            // 
            // textBoxClienteEditar
            // 
            this.textBoxClienteEditar.Location = new System.Drawing.Point(383, 126);
            this.textBoxClienteEditar.Name = "textBoxClienteEditar";
            this.textBoxClienteEditar.Size = new System.Drawing.Size(29, 26);
            this.textBoxClienteEditar.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Estado";
            // 
            // cmbEstadoEdit
            // 
            this.cmbEstadoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstadoEdit.FormattingEnabled = true;
            this.cmbEstadoEdit.Location = new System.Drawing.Point(206, 422);
            this.cmbEstadoEdit.Name = "cmbEstadoEdit";
            this.cmbEstadoEdit.Size = new System.Drawing.Size(159, 28);
            this.cmbEstadoEdit.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(161, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Cliente";
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(96, 180);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(269, 26);
            this.txtNombreEditar.TabIndex = 6;
            this.txtNombreEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEditar_KeyPress);
            // 
            // txtApellidoEditar
            // 
            this.txtApellidoEditar.Location = new System.Drawing.Point(96, 235);
            this.txtApellidoEditar.Name = "txtApellidoEditar";
            this.txtApellidoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtApellidoEditar.TabIndex = 5;
            this.txtApellidoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEditar_KeyPress);
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(96, 295);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtTelefonoEditar.TabIndex = 4;
            this.txtTelefonoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEditar_KeyPress);
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(96, 354);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(269, 26);
            this.txtCorreoEditar.TabIndex = 3;
            this.txtCorreoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoEditar_KeyPress);
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(96, 126);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.Size = new System.Drawing.Size(269, 26);
            this.txtCedulaEditar.TabIndex = 1;
            this.txtCedulaEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaEditar_KeyPress);
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(51, 504);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarCambios.Size = new System.Drawing.Size(213, 52);
            this.btnGuardarCambios.TabIndex = 82;
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
            this.BtnCancelar.Location = new System.Drawing.Point(260, 510);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(145, 40);
            this.BtnCancelar.TabIndex = 81;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(114, 67);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 32);
            this.iconPictureBox1.TabIndex = 83;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 647);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarCliente";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEditarEmpleado_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxClienteEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstadoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.TextBox txtApellidoEditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}