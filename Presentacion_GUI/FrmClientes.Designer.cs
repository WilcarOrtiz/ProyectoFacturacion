namespace Presentacion_GUI
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.IconoBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCup2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconCup1 = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.AllowUserToOrderColumns = true;
            this.GrillaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrillaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrillaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.GrillaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.GrillaClientes.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrillaClientes.Location = new System.Drawing.Point(121, 194);
            this.GrillaClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.GrillaClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaClientes.Size = new System.Drawing.Size(1160, 450);
            this.GrillaClientes.TabIndex = 73;
            this.GrillaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaClientes_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(196, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Buscar por";
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnImprimir.IconColor = System.Drawing.Color.Azure;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 32;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(1040, 81);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnImprimir.Size = new System.Drawing.Size(241, 53);
            this.btnImprimir.TabIndex = 75;
            this.btnImprimir.Text = "Descargar PDF";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Estado"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(380, 94);
            this.cmbTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(141, 28);
            this.cmbTipoBusqueda.TabIndex = 71;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.IconoBuscar.ForeColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.IconoBuscar.IconColor = System.Drawing.Color.Azure;
            this.IconoBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBuscar.Location = new System.Drawing.Point(324, 92);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(32, 32);
            this.IconoBuscar.TabIndex = 74;
            this.IconoBuscar.TabStop = false;
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(545, 94);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(341, 26);
            this.textBusqueda.TabIndex = 72;
            this.textBusqueda.TextChanged += new System.EventHandler(this.textBusqueda_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 291);
            this.panel1.TabIndex = 76;
            // 
            // iconCup2
            // 
            this.iconCup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCup2.ForeColor = System.Drawing.Color.Azure;
            this.iconCup2.IconChar = FontAwesome.Sharp.IconChar.PeopleRobbery;
            this.iconCup2.IconColor = System.Drawing.Color.Azure;
            this.iconCup2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCup2.Location = new System.Drawing.Point(891, 29);
            this.iconCup2.Name = "iconCup2";
            this.iconCup2.Size = new System.Drawing.Size(32, 32);
            this.iconCup2.TabIndex = 79;
            this.iconCup2.TabStop = false;
            // 
            // iconCup1
            // 
            this.iconCup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCup1.ForeColor = System.Drawing.Color.Azure;
            this.iconCup1.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconCup1.IconColor = System.Drawing.Color.Azure;
            this.iconCup1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCup1.Location = new System.Drawing.Point(477, 29);
            this.iconCup1.Name = "iconCup1";
            this.iconCup1.Size = new System.Drawing.Size(32, 32);
            this.iconCup1.TabIndex = 78;
            this.iconCup1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(538, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 42);
            this.label8.TabIndex = 77;
            this.label8.Text = "LISTA DE CLIENTES";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1419, 670);
            this.Controls.Add(this.iconCup2);
            this.Controls.Add(this.iconCup1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrillaClientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbTipoBusqueda);
            this.Controls.Add(this.IconoBuscar);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private FontAwesome.Sharp.IconPictureBox IconoBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private FontAwesome.Sharp.IconPictureBox iconCup2;
        private FontAwesome.Sharp.IconPictureBox iconCup1;
        private System.Windows.Forms.Label label8;
    }
}