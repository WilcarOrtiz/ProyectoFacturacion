namespace Presentacion_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaProductos));
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GrillaCatalogo = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCup2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconCup1 = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.IconoBuscar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(454, 141);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(341, 26);
            this.textBusqueda.TabIndex = 7;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(289, 141);
            this.cmbTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(141, 28);
            this.cmbTipoBusqueda.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(83, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Buscar por";
            // 
            // GrillaCatalogo
            // 
            this.GrillaCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrillaCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Column15});
            this.GrillaCatalogo.Location = new System.Drawing.Point(76, 222);
            this.GrillaCatalogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaCatalogo.Name = "GrillaCatalogo";
            this.GrillaCatalogo.RowHeadersWidth = 62;
            this.GrillaCatalogo.Size = new System.Drawing.Size(1006, 421);
            this.GrillaCatalogo.TabIndex = 8;
            this.GrillaCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCatalogo_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "";
            this.Eliminar.Width = 71;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Editar";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.iconCup2);
            this.panel1.Controls.Add(this.iconCup1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.IconoBuscar);
            this.panel1.Controls.Add(this.GrillaCatalogo);
            this.panel1.Controls.Add(this.textBusqueda);
            this.panel1.Controls.Add(this.cmbTipoBusqueda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(56, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 714);
            this.panel1.TabIndex = 10;
            // 
            // iconCup2
            // 
            this.iconCup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCup2.ForeColor = System.Drawing.Color.Azure;
            this.iconCup2.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iconCup2.IconColor = System.Drawing.Color.Azure;
            this.iconCup2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCup2.Location = new System.Drawing.Point(824, 57);
            this.iconCup2.Name = "iconCup2";
            this.iconCup2.Size = new System.Drawing.Size(32, 32);
            this.iconCup2.TabIndex = 68;
            this.iconCup2.TabStop = false;
            // 
            // iconCup1
            // 
            this.iconCup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCup1.ForeColor = System.Drawing.Color.Azure;
            this.iconCup1.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconCup1.IconColor = System.Drawing.Color.Azure;
            this.iconCup1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCup1.Location = new System.Drawing.Point(346, 57);
            this.iconCup1.Name = "iconCup1";
            this.iconCup1.Size = new System.Drawing.Size(32, 32);
            this.iconCup1.TabIndex = 67;
            this.iconCup1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(384, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 42);
            this.label8.TabIndex = 66;
            this.label8.Text = "CATALOGO PRODUCTOS";
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnImprimir.IconColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 32;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(855, 133);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnImprimir.Size = new System.Drawing.Size(227, 40);
            this.btnImprimir.TabIndex = 62;
            this.btnImprimir.Text = "Descargar";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.IconoBuscar.ForeColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.IconoBuscar.IconColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBuscar.Location = new System.Drawing.Point(232, 141);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(32, 32);
            this.IconoBuscar.TabIndex = 10;
            this.IconoBuscar.TabStop = false;
            // 
            // FrmVistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1287, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaProductos";
            this.Text = "FrmVistaProductos";
            this.Load += new System.EventHandler(this.FrmVistaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCatalogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GrillaCatalogo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox IconoBuscar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconPictureBox iconCup2;
        private FontAwesome.Sharp.IconPictureBox iconCup1;
        private System.Windows.Forms.Label label8;
    }
}