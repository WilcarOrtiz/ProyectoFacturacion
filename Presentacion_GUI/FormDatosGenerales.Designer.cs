namespace Presentacion_GUI
{
    partial class FormDatosGenerales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraficoProductosPreferidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labeltotalVenta = new System.Windows.Forms.Label();
            this.labelCantidadFactura = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconProducto = new FontAwesome.Sharp.IconPictureBox();
            this.iconCliente = new FontAwesome.Sharp.IconPictureBox();
            this.iconEmpleado = new FontAwesome.Sharp.IconPictureBox();
            this.iconFactura = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextEmpleado = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.iconTotal = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoProductosPreferidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoProductosPreferidos
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoProductosPreferidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoProductosPreferidos.Legends.Add(legend2);
            this.GraficoProductosPreferidos.Location = new System.Drawing.Point(679, 208);
            this.GraficoProductosPreferidos.Name = "GraficoProductosPreferidos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GraficoProductosPreferidos.Series.Add(series2);
            this.GraficoProductosPreferidos.Size = new System.Drawing.Size(656, 380);
            this.GraficoProductosPreferidos.TabIndex = 1;
            this.GraficoProductosPreferidos.Text = "Productos Preferidos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 73);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(848, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(541, 42);
            this.label8.TabIndex = 65;
            this.label8.Text = "COMPORTAMIENTO DE VENTAS";
            // 
            // labeltotalVenta
            // 
            this.labeltotalVenta.AutoSize = true;
            this.labeltotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.labeltotalVenta.Location = new System.Drawing.Point(386, 67);
            this.labeltotalVenta.Name = "labeltotalVenta";
            this.labeltotalVenta.Size = new System.Drawing.Size(58, 22);
            this.labeltotalVenta.TabIndex = 3;
            this.labeltotalVenta.Text = "label1";
            // 
            // labelCantidadFactura
            // 
            this.labelCantidadFactura.AutoSize = true;
            this.labelCantidadFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.labelCantidadFactura.Location = new System.Drawing.Point(386, 149);
            this.labelCantidadFactura.Name = "labelCantidadFactura";
            this.labelCantidadFactura.Size = new System.Drawing.Size(58, 22);
            this.labelCantidadFactura.TabIndex = 4;
            this.labelCantidadFactura.Text = "label2";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.labelEmpleado.Location = new System.Drawing.Point(386, 240);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(58, 22);
            this.labelEmpleado.TabIndex = 5;
            this.labelEmpleado.Text = "label3";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.labelProducto.Location = new System.Drawing.Point(414, 411);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(58, 22);
            this.labelProducto.TabIndex = 7;
            this.labelProducto.Text = "label3";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.labelCliente.Location = new System.Drawing.Point(386, 330);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(58, 22);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconProducto);
            this.groupBox1.Controls.Add(this.iconCliente);
            this.groupBox1.Controls.Add(this.iconEmpleado);
            this.groupBox1.Controls.Add(this.iconFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextEmpleado);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.iconTotal);
            this.groupBox1.Controls.Add(this.labelProducto);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Controls.Add(this.labelEmpleado);
            this.groupBox1.Controls.Add(this.labelCantidadFactura);
            this.groupBox1.Controls.Add(this.labeltotalVenta);
            this.groupBox1.Location = new System.Drawing.Point(73, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 491);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de interes";
            // 
            // iconProducto
            // 
            this.iconProducto.BackColor = System.Drawing.Color.White;
            this.iconProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconProducto.IconChar = FontAwesome.Sharp.IconChar.BeerMugEmpty;
            this.iconProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProducto.IconSize = 52;
            this.iconProducto.Location = new System.Drawing.Point(48, 394);
            this.iconProducto.Name = "iconProducto";
            this.iconProducto.Size = new System.Drawing.Size(81, 52);
            this.iconProducto.TabIndex = 17;
            this.iconProducto.TabStop = false;
            // 
            // iconCliente
            // 
            this.iconCliente.BackColor = System.Drawing.Color.White;
            this.iconCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCliente.IconSize = 52;
            this.iconCliente.Location = new System.Drawing.Point(48, 315);
            this.iconCliente.Name = "iconCliente";
            this.iconCliente.Size = new System.Drawing.Size(81, 52);
            this.iconCliente.TabIndex = 16;
            this.iconCliente.TabStop = false;
            // 
            // iconEmpleado
            // 
            this.iconEmpleado.BackColor = System.Drawing.Color.White;
            this.iconEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconEmpleado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmpleado.IconSize = 52;
            this.iconEmpleado.Location = new System.Drawing.Point(48, 226);
            this.iconEmpleado.Name = "iconEmpleado";
            this.iconEmpleado.Size = new System.Drawing.Size(81, 52);
            this.iconEmpleado.TabIndex = 15;
            this.iconEmpleado.TabStop = false;
            // 
            // iconFactura
            // 
            this.iconFactura.BackColor = System.Drawing.Color.White;
            this.iconFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconFactura.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconFactura.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFactura.IconSize = 52;
            this.iconFactura.Location = new System.Drawing.Point(49, 129);
            this.iconFactura.Name = "iconFactura";
            this.iconFactura.Size = new System.Drawing.Size(81, 52);
            this.iconFactura.TabIndex = 14;
            this.iconFactura.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(135, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "N° Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(135, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "N° Empleados activos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(136, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "N° Facturas";
            // 
            // TextEmpleado
            // 
            this.TextEmpleado.AutoSize = true;
            this.TextEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.TextEmpleado.Location = new System.Drawing.Point(135, 411);
            this.TextEmpleado.Name = "TextEmpleado";
            this.TextEmpleado.Size = new System.Drawing.Size(211, 22);
            this.TextEmpleado.TabIndex = 10;
            this.TextEmpleado.Text = "N° Productos disponibles";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Total.Location = new System.Drawing.Point(135, 67);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(87, 22);
            this.Total.TabIndex = 9;
            this.Total.Text = "TOTAL: ";
            // 
            // iconTotal
            // 
            this.iconTotal.BackColor = System.Drawing.Color.White;
            this.iconTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconTotal.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconTotal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTotal.IconSize = 52;
            this.iconTotal.Location = new System.Drawing.Point(48, 52);
            this.iconTotal.Name = "iconTotal";
            this.iconTotal.Size = new System.Drawing.Size(81, 52);
            this.iconTotal.TabIndex = 8;
            this.iconTotal.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(927, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Producto Preferidos";
            // 
            // FormDatosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 668);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GraficoProductosPreferidos);
            this.Name = "FormDatosGenerales";
            this.Text = "FormDatosGenerales";
            this.Load += new System.EventHandler(this.FormDatosGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoProductosPreferidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoProductosPreferidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeltotalVenta;
        private System.Windows.Forms.Label labelCantidadFactura;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TextEmpleado;
        private System.Windows.Forms.Label Total;
        private FontAwesome.Sharp.IconPictureBox iconTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconProducto;
        private FontAwesome.Sharp.IconPictureBox iconCliente;
        private FontAwesome.Sharp.IconPictureBox iconEmpleado;
        private FontAwesome.Sharp.IconPictureBox iconFactura;
        private System.Windows.Forms.Label label4;
    }
}