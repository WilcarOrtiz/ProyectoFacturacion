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
            this.brnGuardarCambios = new System.Windows.Forms.Button();
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtApellidoEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnGuardarCambios
            // 
            this.brnGuardarCambios.Location = new System.Drawing.Point(102, 433);
            this.brnGuardarCambios.Name = "brnGuardarCambios";
            this.brnGuardarCambios.Size = new System.Drawing.Size(170, 30);
            this.brnGuardarCambios.TabIndex = 0;
            this.brnGuardarCambios.Text = "Guardar Cambios";
            this.brnGuardarCambios.UseVisualStyleBackColor = true;
            this.brnGuardarCambios.Click += new System.EventHandler(this.brnGuardarCambios_Click);
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(90, 125);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.Size = new System.Drawing.Size(182, 26);
            this.txtCedulaEditar.TabIndex = 1;
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(90, 353);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(182, 26);
            this.txtCorreoEditar.TabIndex = 3;
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(90, 294);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(182, 26);
            this.txtTelefonoEditar.TabIndex = 4;
            // 
            // txtApellidoEditar
            // 
            this.txtApellidoEditar.Location = new System.Drawing.Point(90, 234);
            this.txtApellidoEditar.Name = "txtApellidoEditar";
            this.txtApellidoEditar.Size = new System.Drawing.Size(182, 26);
            this.txtApellidoEditar.TabIndex = 5;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(90, 179);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(182, 26);
            this.txtNombreEditar.TabIndex = 6;
            // 
            // FrmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 495);
            this.Controls.Add(this.txtNombreEditar);
            this.Controls.Add(this.txtApellidoEditar);
            this.Controls.Add(this.txtTelefonoEditar);
            this.Controls.Add(this.txtCorreoEditar);
            this.Controls.Add(this.txtCedulaEditar);
            this.Controls.Add(this.brnGuardarCambios);
            this.Name = "FrmEditarEmpleado";
            this.Text = "EditarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnGuardarCambios;
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtApellidoEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
    }
}