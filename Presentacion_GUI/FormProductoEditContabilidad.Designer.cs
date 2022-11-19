namespace Presentacion_GUI
{
    partial class FormProductoEditContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductoEditContabilidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CantidadEdit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUnidadesEdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadInicial = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioVEdit = new System.Windows.Forms.TextBox();
            this.txtPrecioCEdit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textIDProductoEdit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.textIDProductoEdit);
            this.panel1.Controls.Add(this.CantidadEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbUnidadesEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CantidadInicial);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtPrecioVEdit);
            this.panel1.Controls.Add(this.txtPrecioCEdit);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 586);
            this.panel1.TabIndex = 0;
            // 
            // CantidadEdit
            // 
            this.CantidadEdit.Location = new System.Drawing.Point(263, 201);
            this.CantidadEdit.Name = "CantidadEdit";
            this.CantidadEdit.Size = new System.Drawing.Size(159, 26);
            this.CantidadEdit.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(258, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Cantidad a adicionar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(39, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "Unidad";
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
            this.cmbUnidadesEdit.Location = new System.Drawing.Point(37, 199);
            this.cmbUnidadesEdit.Name = "cmbUnidadesEdit";
            this.cmbUnidadesEdit.Size = new System.Drawing.Size(181, 28);
            this.cmbUnidadesEdit.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 94;
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.ForeColor = System.Drawing.Color.Azure;
            this.CantidadInicial.Location = new System.Drawing.Point(358, 401);
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.Size = new System.Drawing.Size(52, 23);
            this.CantidadInicial.TabIndex = 93;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Azure;
            this.label16.Location = new System.Drawing.Point(27, 401);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 20);
            this.label16.TabIndex = 92;
            this.label16.Text = "Cantidad unitaria en bodega: ";
            // 
            // txtPrecioVEdit
            // 
            this.txtPrecioVEdit.Location = new System.Drawing.Point(263, 314);
            this.txtPrecioVEdit.Name = "txtPrecioVEdit";
            this.txtPrecioVEdit.Size = new System.Drawing.Size(162, 26);
            this.txtPrecioVEdit.TabIndex = 91;
            // 
            // txtPrecioCEdit
            // 
            this.txtPrecioCEdit.Location = new System.Drawing.Point(32, 314);
            this.txtPrecioCEdit.Name = "txtPrecioCEdit";
            this.txtPrecioCEdit.Size = new System.Drawing.Size(186, 26);
            this.txtPrecioCEdit.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(262, 277);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "Precio de Venta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(31, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "Precio de Compra";
            // 
            // textIDProductoEdit
            // 
            this.textIDProductoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textIDProductoEdit.ForeColor = System.Drawing.Color.Azure;
            this.textIDProductoEdit.Location = new System.Drawing.Point(31, 20);
            this.textIDProductoEdit.Name = "textIDProductoEdit";
            this.textIDProductoEdit.Size = new System.Drawing.Size(26, 26);
            this.textIDProductoEdit.TabIndex = 99;
            // 
            // FormProductoEditContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 624);
            this.Controls.Add(this.panel1);
            this.Name = "FormProductoEditContabilidad";
            this.Text = "FormProductoEditContabilidad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown CantidadEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUnidadesEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CantidadInicial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioVEdit;
        private System.Windows.Forms.TextBox txtPrecioCEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textIDProductoEdit;
    }
}