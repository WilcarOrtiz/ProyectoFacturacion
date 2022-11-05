namespace PresentacionGui
{
    partial class FrmProductosEdit
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
            this.CantidadInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigoEditar = new System.Windows.Forms.TextBox();
            this.CantidadEdit = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVEdit = new System.Windows.Forms.TextBox();
            this.txtPrecioCEdit = new System.Windows.Forms.TextBox();
            this.txtDescripEditar = new System.Windows.Forms.TextBox();
            this.txtNombreProducEditar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUnidadesEdit = new System.Windows.Forms.ComboBox();
            this.BtnGuardarEdit = new FontAwesome.Sharp.IconButton();
            this.BtnCancelarEdit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.AutoSize = true;
            this.CantidadInicial.Location = new System.Drawing.Point(265, 410);
            this.CantidadInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.Size = new System.Drawing.Size(0, 20);
            this.CantidadInicial.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(75, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Cantidad a adicionar:";
            // 
            // textCodigoEditar
            // 
            this.textCodigoEditar.Location = new System.Drawing.Point(291, 208);
            this.textCodigoEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCodigoEditar.Name = "textCodigoEditar";
            this.textCodigoEditar.Size = new System.Drawing.Size(96, 26);
            this.textCodigoEditar.TabIndex = 72;
            // 
            // CantidadEdit
            // 
            this.CantidadEdit.Location = new System.Drawing.Point(269, 357);
            this.CantidadEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CantidadEdit.Name = "CantidadEdit";
            this.CantidadEdit.Size = new System.Drawing.Size(88, 26);
            this.CantidadEdit.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Azure;
            this.label16.Location = new System.Drawing.Point(73, 410);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 20);
            this.label16.TabIndex = 70;
            this.label16.Text = "Cantidad en bodega: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(77, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Unidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(78, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Descripcion";
            // 
            // txtPrecioVEdit
            // 
            this.txtPrecioVEdit.Location = new System.Drawing.Point(267, 294);
            this.txtPrecioVEdit.Name = "txtPrecioVEdit";
            this.txtPrecioVEdit.Size = new System.Drawing.Size(118, 26);
            this.txtPrecioVEdit.TabIndex = 67;
            // 
            // txtPrecioCEdit
            // 
            this.txtPrecioCEdit.Location = new System.Drawing.Point(80, 294);
            this.txtPrecioCEdit.Name = "txtPrecioCEdit";
            this.txtPrecioCEdit.Size = new System.Drawing.Size(163, 26);
            this.txtPrecioCEdit.TabIndex = 61;
            // 
            // txtDescripEditar
            // 
            this.txtDescripEditar.Location = new System.Drawing.Point(186, 134);
            this.txtDescripEditar.Name = "txtDescripEditar";
            this.txtDescripEditar.Size = new System.Drawing.Size(201, 26);
            this.txtDescripEditar.TabIndex = 60;
            // 
            // txtNombreProducEditar
            // 
            this.txtNombreProducEditar.Location = new System.Drawing.Point(150, 85);
            this.txtNombreProducEditar.Name = "txtNombreProducEditar";
            this.txtNombreProducEditar.Size = new System.Drawing.Size(235, 26);
            this.txtNombreProducEditar.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(265, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "Precio de Venta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(77, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "Precio de Compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(78, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Azure;
            this.label15.Location = new System.Drawing.Point(287, 182);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 63;
            this.label15.Text = "Codigo";
            // 
            // cmbUnidadesEdit
            // 
            this.cmbUnidadesEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnidadesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadesEdit.FormattingEnabled = true;
            this.cmbUnidadesEdit.Items.AddRange(new object[] {
            "UNIDAD",
            "CAJA (24 Unds)",
            "CANASTA (30 Unds)"});
            this.cmbUnidadesEdit.Location = new System.Drawing.Point(81, 208);
            this.cmbUnidadesEdit.Name = "cmbUnidadesEdit";
            this.cmbUnidadesEdit.Size = new System.Drawing.Size(163, 28);
            this.cmbUnidadesEdit.TabIndex = 62;
            // 
            // BtnGuardarEdit
            // 
            this.BtnGuardarEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarEdit.FlatAppearance.BorderSize = 0;
            this.BtnGuardarEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnGuardarEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuardarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarEdit.ForeColor = System.Drawing.Color.Azure;
            this.BtnGuardarEdit.IconChar = FontAwesome.Sharp.IconChar.FilePen; 
            this.BtnGuardarEdit.IconColor = System.Drawing.Color.Azure;
            this.BtnGuardarEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarEdit.IconSize = 32;
            this.BtnGuardarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEdit.Location = new System.Drawing.Point(67, 468);
            this.BtnGuardarEdit.Name = "BtnGuardarEdit";
            this.BtnGuardarEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGuardarEdit.Size = new System.Drawing.Size(176, 45);
            this.BtnGuardarEdit.TabIndex = 75;
            this.BtnGuardarEdit.Text = "Editar";
            this.BtnGuardarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardarEdit.UseVisualStyleBackColor = false;
            // 
            // BtnCancelarEdit
            // 
            this.BtnCancelarEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarEdit.FlatAppearance.BorderSize = 0;
            this.BtnCancelarEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.BtnCancelarEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancelarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarEdit.ForeColor = System.Drawing.Color.Azure;
            this.BtnCancelarEdit.IconChar = FontAwesome.Sharp.IconChar.Cancel; 
            this.BtnCancelarEdit.IconColor = System.Drawing.Color.Azure;
            this.BtnCancelarEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelarEdit.IconSize = 32;
            this.BtnCancelarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEdit.Location = new System.Drawing.Point(249, 468);
            this.BtnCancelarEdit.Name = "BtnCancelarEdit";
            this.BtnCancelarEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCancelarEdit.Size = new System.Drawing.Size(176, 45);
            this.BtnCancelarEdit.TabIndex = 76;
            this.BtnCancelarEdit.Text = "Cancelar";
            this.BtnCancelarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarEdit.UseVisualStyleBackColor = false;
            // 
            // FrmProductosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(493, 557);
            this.Controls.Add(this.BtnCancelarEdit);
            this.Controls.Add(this.BtnGuardarEdit);
            this.Controls.Add(this.CantidadInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodigoEditar);
            this.Controls.Add(this.CantidadEdit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecioVEdit);
            this.Controls.Add(this.txtPrecioCEdit);
            this.Controls.Add(this.txtDescripEditar);
            this.Controls.Add(this.txtNombreProducEditar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbUnidadesEdit);
            this.Name = "FrmProductosEdit";
            this.Text = "FrmProductosEdit";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CantidadInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigoEditar;
        private System.Windows.Forms.NumericUpDown CantidadEdit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVEdit;
        private System.Windows.Forms.TextBox txtPrecioCEdit;
        private System.Windows.Forms.TextBox txtDescripEditar;
        private System.Windows.Forms.TextBox txtNombreProducEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbUnidadesEdit;
        private FontAwesome.Sharp.IconButton BtnGuardarEdit;
        private FontAwesome.Sharp.IconButton BtnCancelarEdit;
    }
}