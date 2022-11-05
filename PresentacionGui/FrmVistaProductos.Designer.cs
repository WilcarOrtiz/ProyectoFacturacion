namespace PresentacionGui
{
    partial class FrmVistaProductos
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
            this.GrillaCatalogo = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.IconoBuscar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaCatalogo
            // 
            this.GrillaCatalogo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrillaCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Column15});
            this.GrillaCatalogo.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrillaCatalogo.Location = new System.Drawing.Point(28, 78);
            this.GrillaCatalogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaCatalogo.Name = "GrillaCatalogo";
            this.GrillaCatalogo.RowHeadersWidth = 62;
            this.GrillaCatalogo.Size = new System.Drawing.Size(1094, 421);
            this.GrillaCatalogo.TabIndex = 13;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "";
            this.Eliminar.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Editar";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(323, 34);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(264, 26);
            this.textBusqueda.TabIndex = 12;
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(161, 32);
            this.cmbTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(141, 28);
            this.cmbTipoBusqueda.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(67, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Buscar por";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnImprimir.IconColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 32;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(946, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnImprimir.Size = new System.Drawing.Size(176, 45);
            this.btnImprimir.TabIndex = 69;
            this.btnImprimir.Text = "Descargar";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.IconoBuscar.ForeColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconoBuscar.IconColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBuscar.Location = new System.Drawing.Point(28, 32);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(32, 32);
            this.IconoBuscar.TabIndex = 70;
            this.IconoBuscar.TabStop = false;
            // 
            // FrmVistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1147, 557);
            this.Controls.Add(this.IconoBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.GrillaCatalogo);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.cmbTipoBusqueda);
            this.Controls.Add(this.label10);
            this.Name = "FrmVistaProductos";
            this.Text = "FrmVistaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GrillaCatalogo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconPictureBox IconoBuscar;
    }
}