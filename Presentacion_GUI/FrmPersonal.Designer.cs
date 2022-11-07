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
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.pbGuardarPersonal = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.pbFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).BeginInit();
            this.gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.pbGuardarPersonal);
            this.gbIngreso.Controls.Add(this.txtContraseña);
            this.gbIngreso.Controls.Add(this.txtTelefono);
            this.gbIngreso.Controls.Add(this.txtCorreo);
            this.gbIngreso.Controls.Add(this.txtApellidos);
            this.gbIngreso.Controls.Add(this.txtNombres);
            this.gbIngreso.Controls.Add(this.txtCedula);
            this.gbIngreso.Controls.Add(this.pbFotoEmpleado);
            this.gbIngreso.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gbIngreso.Location = new System.Drawing.Point(25, 38);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(351, 638);
            this.gbIngreso.TabIndex = 1;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso";
            // 
            // pbGuardarPersonal
            // 
            this.pbGuardarPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardarPersonal.Image")));
            this.pbGuardarPersonal.Location = new System.Drawing.Point(135, 513);
            this.pbGuardarPersonal.Name = "pbGuardarPersonal";
            this.pbGuardarPersonal.Size = new System.Drawing.Size(92, 83);
            this.pbGuardarPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardarPersonal.TabIndex = 8;
            this.pbGuardarPersonal.TabStop = false;
            this.pbGuardarPersonal.Click += new System.EventHandler(this.pbGuardarPersonal_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(56, 453);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(228, 26);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(56, 345);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(228, 26);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(56, 399);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 26);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(56, 296);
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
            this.txtNombres.Location = new System.Drawing.Point(56, 243);
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
            this.txtCedula.Location = new System.Drawing.Point(56, 190);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 26);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "Cedula";
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // pbFotoEmpleado
            // 
            this.pbFotoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFotoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoEmpleado.Image")));
            this.pbFotoEmpleado.Location = new System.Drawing.Point(111, 31);
            this.pbFotoEmpleado.Name = "pbFotoEmpleado";
            this.pbFotoEmpleado.Size = new System.Drawing.Size(116, 117);
            this.pbFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFotoEmpleado.TabIndex = 0;
            this.pbFotoEmpleado.TabStop = false;
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.GrillaEmpleados);
            this.gbLista.Location = new System.Drawing.Point(399, 38);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(710, 638);
            this.gbLista.TabIndex = 2;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista";
            // 
            // GrillaEmpleados
            // 
            this.GrillaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrillaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Correo});
            this.GrillaEmpleados.Location = new System.Drawing.Point(16, 175);
            this.GrillaEmpleados.Name = "GrillaEmpleados";
            this.GrillaEmpleados.RowHeadersWidth = 62;
            this.GrillaEmpleados.RowTemplate.Height = 28;
            this.GrillaEmpleados.Size = new System.Drawing.Size(674, 435);
            this.GrillaEmpleados.TabIndex = 0;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cedula.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 101;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 101;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 107;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.Width = 93;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1260, 742);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).EndInit();
            this.gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.PictureBox pbGuardarPersonal;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.PictureBox pbFotoEmpleado;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}