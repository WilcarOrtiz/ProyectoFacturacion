namespace Presentacion_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosEdit));
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnGuardarEdit = new FontAwesome.Sharp.IconButton();
            this.BtnCancelarEdit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textIDProductoEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoEdit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbnCategoriaEdit = new System.Windows.Forms.ComboBox();
            this.textCodigoEditar = new System.Windows.Forms.TextBox();
            this.txtDescripEditar = new System.Windows.Forms.TextBox();
            this.txtNombreProducEditar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioCEdit = new System.Windows.Forms.TextBox();
            this.txtPrecioVEdit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CantidadInicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUnidadesEdit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadEdit = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(53, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Descripcion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(50, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Azure;
            this.label15.Location = new System.Drawing.Point(174, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Codigo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // BtnGuardarEdit
            // 
            this.BtnGuardarEdit.FlatAppearance.BorderSize = 0;
            this.BtnGuardarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarEdit.ForeColor = System.Drawing.Color.Azure;
            this.BtnGuardarEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnGuardarEdit.IconColor = System.Drawing.Color.Azure;
            this.BtnGuardarEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarEdit.IconSize = 32;
            this.BtnGuardarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEdit.Location = new System.Drawing.Point(57, 577);
            this.BtnGuardarEdit.Name = "BtnGuardarEdit";
            this.BtnGuardarEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGuardarEdit.Size = new System.Drawing.Size(168, 40);
            this.BtnGuardarEdit.TabIndex = 60;
            this.BtnGuardarEdit.Text = "Editar";
            this.BtnGuardarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardarEdit.UseVisualStyleBackColor = true;
            this.BtnGuardarEdit.Click += new System.EventHandler(this.BtnGuardarEdit_Click_1);
            // 
            // BtnCancelarEdit
            // 
            this.BtnCancelarEdit.FlatAppearance.BorderSize = 0;
            this.BtnCancelarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarEdit.ForeColor = System.Drawing.Color.Azure;
            this.BtnCancelarEdit.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelarEdit.IconColor = System.Drawing.Color.Azure;
            this.BtnCancelarEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelarEdit.IconSize = 32;
            this.BtnCancelarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEdit.Location = new System.Drawing.Point(282, 579);
            this.BtnCancelarEdit.Name = "BtnCancelarEdit";
            this.BtnCancelarEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCancelarEdit.Size = new System.Drawing.Size(168, 40);
            this.BtnCancelarEdit.TabIndex = 61;
            this.BtnCancelarEdit.Text = "Cancelar";
            this.BtnCancelarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarEdit.UseVisualStyleBackColor = true;
            this.BtnCancelarEdit.Click += new System.EventHandler(this.BtnCancelarEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.textIDProductoEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEstadoEdit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbnCategoriaEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnCancelarEdit);
            this.panel1.Controls.Add(this.BtnGuardarEdit);
            this.panel1.Controls.Add(this.CantidadEdit);
            this.panel1.Controls.Add(this.CantidadInicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCodigoEditar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPrecioVEdit);
            this.panel1.Controls.Add(this.txtPrecioCEdit);
            this.panel1.Controls.Add(this.txtDescripEditar);
            this.panel1.Controls.Add(this.txtNombreProducEditar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmbUnidadesEdit);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 645);
            this.panel1.TabIndex = 62;
            // 
            // textIDProductoEdit
            // 
            this.textIDProductoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textIDProductoEdit.ForeColor = System.Drawing.Color.Azure;
            this.textIDProductoEdit.Location = new System.Drawing.Point(57, 40);
            this.textIDProductoEdit.Name = "textIDProductoEdit";
            this.textIDProductoEdit.Size = new System.Drawing.Size(26, 26);
            this.textIDProductoEdit.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Disponibiliad";
            // 
            // cmbEstadoEdit
            // 
            this.cmbEstadoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstadoEdit.FormattingEnabled = true;
            this.cmbEstadoEdit.Location = new System.Drawing.Point(269, 345);
            this.cmbEstadoEdit.Name = "cmbEstadoEdit";
            this.cmbEstadoEdit.Size = new System.Drawing.Size(159, 28);
            this.cmbEstadoEdit.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(49, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "Categoria";
            // 
            // cbnCategoriaEdit
            // 
            this.cbnCategoriaEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbnCategoriaEdit.FormattingEnabled = true;
            this.cbnCategoriaEdit.Location = new System.Drawing.Point(47, 345);
            this.cbnCategoriaEdit.Name = "cbnCategoriaEdit";
            this.cbnCategoriaEdit.Size = new System.Drawing.Size(183, 28);
            this.cbnCategoriaEdit.TabIndex = 72;
            // 
            // textCodigoEditar
            // 
            this.textCodigoEditar.Location = new System.Drawing.Point(251, 41);
            this.textCodigoEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCodigoEditar.Name = "textCodigoEditar";
            this.textCodigoEditar.Size = new System.Drawing.Size(177, 26);
            this.textCodigoEditar.TabIndex = 53;
            this.textCodigoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoEditar_KeyPress);
            // 
            // txtDescripEditar
            // 
            this.txtDescripEditar.Location = new System.Drawing.Point(175, 164);
            this.txtDescripEditar.Name = "txtDescripEditar";
            this.txtDescripEditar.Size = new System.Drawing.Size(253, 26);
            this.txtDescripEditar.TabIndex = 39;
            this.txtDescripEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripEditar_KeyPress);
            // 
            // txtNombreProducEditar
            // 
            this.txtNombreProducEditar.Location = new System.Drawing.Point(175, 99);
            this.txtNombreProducEditar.Name = "txtNombreProducEditar";
            this.txtNombreProducEditar.Size = new System.Drawing.Size(253, 26);
            this.txtNombreProducEditar.TabIndex = 38;
            this.txtNombreProducEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducEditar_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(43, 404);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Precio de Compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(265, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Precio de Venta";
            // 
            // txtPrecioCEdit
            // 
            this.txtPrecioCEdit.Location = new System.Drawing.Point(44, 441);
            this.txtPrecioCEdit.Name = "txtPrecioCEdit";
            this.txtPrecioCEdit.Size = new System.Drawing.Size(186, 26);
            this.txtPrecioCEdit.TabIndex = 40;
            this.txtPrecioCEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCEdit_KeyPress);
            // 
            // txtPrecioVEdit
            // 
            this.txtPrecioVEdit.Location = new System.Drawing.Point(266, 439);
            this.txtPrecioVEdit.Name = "txtPrecioVEdit";
            this.txtPrecioVEdit.Size = new System.Drawing.Size(162, 26);
            this.txtPrecioVEdit.TabIndex = 47;
            this.txtPrecioVEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVEdit_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Azure;
            this.label16.Location = new System.Drawing.Point(39, 500);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Cantidad unitaria en bodega: ";
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.ForeColor = System.Drawing.Color.Azure;
            this.CantidadInicial.Location = new System.Drawing.Point(370, 500);
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.Size = new System.Drawing.Size(52, 23);
            this.CantidadInicial.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 63;
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
            this.cmbUnidadesEdit.Location = new System.Drawing.Point(49, 256);
            this.cmbUnidadesEdit.Name = "cmbUnidadesEdit";
            this.cmbUnidadesEdit.Size = new System.Drawing.Size(181, 28);
            this.cmbUnidadesEdit.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(51, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Unidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(264, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cantidad a adicionar:";
            // 
            // CantidadEdit
            // 
            this.CantidadEdit.Location = new System.Drawing.Point(269, 256);
            this.CantidadEdit.Name = "CantidadEdit";
            this.CantidadEdit.Size = new System.Drawing.Size(159, 26);
            this.CantidadEdit.TabIndex = 59;
            // 
            // FrmProductosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductosEdit";
            this.Text = "FrmProductosEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton BtnGuardarEdit;
        private FontAwesome.Sharp.IconButton BtnCancelarEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textCodigoEditar;
        private System.Windows.Forms.TextBox txtDescripEditar;
        private System.Windows.Forms.TextBox txtNombreProducEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstadoEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbnCategoriaEdit;
        private System.Windows.Forms.TextBox textIDProductoEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CantidadEdit;
        private System.Windows.Forms.Label CantidadInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioVEdit;
        private System.Windows.Forms.TextBox txtPrecioCEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUnidadesEdit;
    }
}