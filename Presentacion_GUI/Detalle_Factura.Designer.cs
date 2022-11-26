namespace Presentacion_GUI
{
    partial class Detalle_Factura
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnGenerarPdf = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBuscarFactura = new System.Windows.Forms.TextBox();
            this.textIva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textCambio = new System.Windows.Forms.TextBox();
            this.textDescuento = new System.Windows.Forms.TextBox();
            this.textMontoPago = new System.Windows.Forms.TextBox();
            this.DataGrillaProductosDetalleFacutra = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.textCedulaCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Facturacion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFechaFacturacion = new System.Windows.Forms.TextBox();
            this.textNombreEmpleado = new System.Windows.Forms.TextBox();
            this.textCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorFechas = new FontAwesome.Sharp.IconButton();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimeFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTotalGenerado = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DescargarExcel = new FontAwesome.Sharp.IconButton();
            this.textBoxBusquedaFiltro = new System.Windows.Forms.TextBox();
            this.DataGrillaReportesFacturas = new System.Windows.Forms.DataGridView();
            this.Fecha_Facturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarTab2 = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.btnBuscarReportesFiltro = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosDetalleFacutra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Facturacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaReportesFacturas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 724);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.BtnGenerarPdf);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxBuscarFactura);
            this.tabPage1.Controls.Add(this.textIva);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textTotal);
            this.tabPage1.Controls.Add(this.textCambio);
            this.tabPage1.Controls.Add(this.textDescuento);
            this.tabPage1.Controls.Add(this.textMontoPago);
            this.tabPage1.Controls.Add(this.DataGrillaProductosDetalleFacutra);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Facturacion);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1430, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalles";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Azure;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnEliminar.IconColor = System.Drawing.Color.Azure;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 32;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(741, 179);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnEliminar.Size = new System.Drawing.Size(199, 40);
            this.BtnEliminar.TabIndex = 70;
            this.BtnEliminar.Text = "Limpiar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Azure;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.BtnBuscar.IconColor = System.Drawing.Color.Azure;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 32;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(473, 179);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(215, 40);
            this.BtnBuscar.TabIndex = 69;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnGenerarPdf
            // 
            this.BtnGenerarPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarPdf.FlatAppearance.BorderSize = 0;
            this.BtnGenerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarPdf.ForeColor = System.Drawing.Color.Azure;
            this.BtnGenerarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.BtnGenerarPdf.IconColor = System.Drawing.Color.Azure;
            this.BtnGenerarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGenerarPdf.IconSize = 32;
            this.BtnGenerarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarPdf.Location = new System.Drawing.Point(1003, 179);
            this.BtnGenerarPdf.Name = "BtnGenerarPdf";
            this.BtnGenerarPdf.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGenerarPdf.Size = new System.Drawing.Size(288, 40);
            this.BtnGenerarPdf.TabIndex = 68;
            this.BtnGenerarPdf.Text = "Generar PDF";
            this.BtnGenerarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGenerarPdf.UseVisualStyleBackColor = true;
            this.BtnGenerarPdf.Click += new System.EventHandler(this.BtnGenerarPdf_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(469, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Numero Factura";
            // 
            // textBoxBuscarFactura
            // 
            this.textBoxBuscarFactura.Location = new System.Drawing.Point(473, 128);
            this.textBoxBuscarFactura.Name = "textBoxBuscarFactura";
            this.textBoxBuscarFactura.Size = new System.Drawing.Size(407, 26);
            this.textBoxBuscarFactura.TabIndex = 51;
            // 
            // textIva
            // 
            this.textIva.Location = new System.Drawing.Point(1079, 508);
            this.textIva.Name = "textIva";
            this.textIva.ReadOnly = true;
            this.textIva.Size = new System.Drawing.Size(199, 26);
            this.textIva.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(999, 508);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Iva";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(942, 461);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(966, 559);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cambio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(935, 418);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Monto pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(985, 609);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(1079, 609);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(199, 26);
            this.textTotal.TabIndex = 58;
            // 
            // textCambio
            // 
            this.textCambio.Location = new System.Drawing.Point(1079, 559);
            this.textCambio.Name = "textCambio";
            this.textCambio.ReadOnly = true;
            this.textCambio.Size = new System.Drawing.Size(199, 26);
            this.textCambio.TabIndex = 57;
            // 
            // textDescuento
            // 
            this.textDescuento.Location = new System.Drawing.Point(1079, 461);
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.ReadOnly = true;
            this.textDescuento.Size = new System.Drawing.Size(199, 26);
            this.textDescuento.TabIndex = 56;
            // 
            // textMontoPago
            // 
            this.textMontoPago.Location = new System.Drawing.Point(1079, 418);
            this.textMontoPago.Name = "textMontoPago";
            this.textMontoPago.ReadOnly = true;
            this.textMontoPago.Size = new System.Drawing.Size(199, 26);
            this.textMontoPago.TabIndex = 55;
            // 
            // DataGrillaProductosDetalleFacutra
            // 
            this.DataGrillaProductosDetalleFacutra.AllowUserToAddRows = false;
            this.DataGrillaProductosDetalleFacutra.BackgroundColor = System.Drawing.Color.White;
            this.DataGrillaProductosDetalleFacutra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrillaProductosDetalleFacutra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrillaProductosDetalleFacutra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Precio,
            this.Unidades,
            this.Importe});
            this.DataGrillaProductosDetalleFacutra.GridColor = System.Drawing.Color.White;
            this.DataGrillaProductosDetalleFacutra.Location = new System.Drawing.Point(51, 409);
            this.DataGrillaProductosDetalleFacutra.Name = "DataGrillaProductosDetalleFacutra";
            this.DataGrillaProductosDetalleFacutra.ReadOnly = true;
            this.DataGrillaProductosDetalleFacutra.RowHeadersWidth = 62;
            this.DataGrillaProductosDetalleFacutra.RowTemplate.Height = 28;
            this.DataGrillaProductosDetalleFacutra.Size = new System.Drawing.Size(664, 242);
            this.DataGrillaProductosDetalleFacutra.TabIndex = 54;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Producto";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 8;
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            this.Unidades.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNombreCliente);
            this.groupBox1.Controls.Add(this.textCedulaCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(450, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 112);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(564, 47);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.ReadOnly = true;
            this.textNombreCliente.Size = new System.Drawing.Size(311, 26);
            this.textNombreCliente.TabIndex = 4;
            // 
            // textCedulaCliente
            // 
            this.textCedulaCliente.Location = new System.Drawing.Point(155, 50);
            this.textCedulaCliente.Name = "textCedulaCliente";
            this.textCedulaCliente.ReadOnly = true;
            this.textCedulaCliente.Size = new System.Drawing.Size(176, 26);
            this.textCedulaCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(451, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(46, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cedula";
            // 
            // Facturacion
            // 
            this.Facturacion.Controls.Add(this.label4);
            this.Facturacion.Controls.Add(this.textFechaFacturacion);
            this.Facturacion.Controls.Add(this.textNombreEmpleado);
            this.Facturacion.Controls.Add(this.textCedulaEmpleado);
            this.Facturacion.Controls.Add(this.label6);
            this.Facturacion.Controls.Add(this.label1);
            this.Facturacion.ForeColor = System.Drawing.Color.Azure;
            this.Facturacion.Location = new System.Drawing.Point(51, 93);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(346, 276);
            this.Facturacion.TabIndex = 51;
            this.Facturacion.TabStop = false;
            this.Facturacion.Text = "Facturacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(50, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fecha";
            // 
            // textFechaFacturacion
            // 
            this.textFechaFacturacion.Location = new System.Drawing.Point(44, 73);
            this.textFechaFacturacion.Name = "textFechaFacturacion";
            this.textFechaFacturacion.ReadOnly = true;
            this.textFechaFacturacion.Size = new System.Drawing.Size(251, 26);
            this.textFechaFacturacion.TabIndex = 49;
            // 
            // textNombreEmpleado
            // 
            this.textNombreEmpleado.Location = new System.Drawing.Point(44, 227);
            this.textNombreEmpleado.Name = "textNombreEmpleado";
            this.textNombreEmpleado.ReadOnly = true;
            this.textNombreEmpleado.Size = new System.Drawing.Size(251, 26);
            this.textNombreEmpleado.TabIndex = 2;
            // 
            // textCedulaEmpleado
            // 
            this.textCedulaEmpleado.Location = new System.Drawing.Point(44, 150);
            this.textCedulaEmpleado.Name = "textCedulaEmpleado";
            this.textCedulaEmpleado.ReadOnly = true;
            this.textCedulaEmpleado.Size = new System.Drawing.Size(251, 26);
            this.textCedulaEmpleado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(40, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(40, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Empleado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 68);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(1120, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 42);
            this.label8.TabIndex = 64;
            this.label8.Text = "DETALLES VENTA";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.textBoxTotalGenerado);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.DescargarExcel);
            this.tabPage2.Controls.Add(this.textBoxBusquedaFiltro);
            this.tabPage2.Controls.Add(this.DataGrillaReportesFacturas);
            this.tabPage2.Controls.Add(this.btnLimpiarTab2);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.comboBoxBusqueda);
            this.tabPage2.Controls.Add(this.btnBuscarReportesFiltro);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1430, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPorFechas);
            this.groupBox2.Controls.Add(this.dateTimeFechaInicio);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dateTimeFechaFinal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(93, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1260, 107);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro por fechas";
            // 
            // btnBuscarPorFechas
            // 
            this.btnBuscarPorFechas.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorFechas.ForeColor = System.Drawing.Color.Azure;
            this.btnBuscarPorFechas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarPorFechas.IconColor = System.Drawing.Color.YellowGreen;
            this.btnBuscarPorFechas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPorFechas.IconSize = 32;
            this.btnBuscarPorFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPorFechas.Location = new System.Drawing.Point(982, 37);
            this.btnBuscarPorFechas.Name = "btnBuscarPorFechas";
            this.btnBuscarPorFechas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscarPorFechas.Size = new System.Drawing.Size(161, 44);
            this.btnBuscarPorFechas.TabIndex = 62;
            this.btnBuscarPorFechas.Text = "Buscar";
            this.btnBuscarPorFechas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPorFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPorFechas.UseVisualStyleBackColor = true;
            this.btnBuscarPorFechas.Click += new System.EventHandler(this.btnBuscarPorFechas_Click);
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(222, 46);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(219, 26);
            this.dateTimeFechaInicio.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(69, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "Fecha Inicio";
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(669, 45);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(215, 26);
            this.dateTimeFechaFinal.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Azure;
            this.label15.Location = new System.Drawing.Point(502, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 54;
            this.label15.Text = "Fecha Final";
            // 
            // textBoxTotalGenerado
            // 
            this.textBoxTotalGenerado.Location = new System.Drawing.Point(200, 639);
            this.textBoxTotalGenerado.Name = "textBoxTotalGenerado";
            this.textBoxTotalGenerado.Size = new System.Drawing.Size(171, 26);
            this.textBoxTotalGenerado.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Azure;
            this.label17.Location = new System.Drawing.Point(41, 640);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 25);
            this.label17.TabIndex = 63;
            this.label17.Text = "Total Filtrado: ";
            // 
            // DescargarExcel
            // 
            this.DescargarExcel.FlatAppearance.BorderSize = 0;
            this.DescargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescargarExcel.ForeColor = System.Drawing.Color.Azure;
            this.DescargarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.DescargarExcel.IconColor = System.Drawing.Color.Azure;
            this.DescargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DescargarExcel.IconSize = 32;
            this.DescargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescargarExcel.Location = new System.Drawing.Point(882, 621);
            this.DescargarExcel.Name = "DescargarExcel";
            this.DescargarExcel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DescargarExcel.Size = new System.Drawing.Size(292, 44);
            this.DescargarExcel.TabIndex = 61;
            this.DescargarExcel.Text = "Descargar Excel";
            this.DescargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DescargarExcel.UseVisualStyleBackColor = true;
            this.DescargarExcel.Click += new System.EventHandler(this.DescargarExcel_Click);
            // 
            // textBoxBusquedaFiltro
            // 
            this.textBoxBusquedaFiltro.Location = new System.Drawing.Point(303, 286);
            this.textBoxBusquedaFiltro.Name = "textBoxBusquedaFiltro";
            this.textBoxBusquedaFiltro.Size = new System.Drawing.Size(304, 26);
            this.textBoxBusquedaFiltro.TabIndex = 60;
            // 
            // DataGrillaReportesFacturas
            // 
            this.DataGrillaReportesFacturas.AllowUserToAddRows = false;
            this.DataGrillaReportesFacturas.BackgroundColor = System.Drawing.Color.White;
            this.DataGrillaReportesFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrillaReportesFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrillaReportesFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_Facturacion,
            this.Factura,
            this.Total,
            this.Empleado,
            this.Cliente,
            this.Codigo,
            this.Nombre_Producto,
            this.Descripcion_Producto,
            this.Precio_Venta});
            this.DataGrillaReportesFacturas.Cursor = System.Windows.Forms.Cursors.No;
            this.DataGrillaReportesFacturas.GridColor = System.Drawing.Color.White;
            this.DataGrillaReportesFacturas.Location = new System.Drawing.Point(34, 359);
            this.DataGrillaReportesFacturas.Name = "DataGrillaReportesFacturas";
            this.DataGrillaReportesFacturas.ReadOnly = true;
            this.DataGrillaReportesFacturas.RowHeadersWidth = 62;
            this.DataGrillaReportesFacturas.RowTemplate.Height = 28;
            this.DataGrillaReportesFacturas.Size = new System.Drawing.Size(1346, 242);
            this.DataGrillaReportesFacturas.TabIndex = 59;
            // 
            // Fecha_Facturacion
            // 
            this.Fecha_Facturacion.HeaderText = "Fecha_Facturacion";
            this.Fecha_Facturacion.MinimumWidth = 8;
            this.Fecha_Facturacion.Name = "Fecha_Facturacion";
            this.Fecha_Facturacion.ReadOnly = true;
            this.Fecha_Facturacion.Width = 150;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.MinimumWidth = 8;
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 8;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 8;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre_Producto";
            this.Nombre_Producto.MinimumWidth = 8;
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            this.Nombre_Producto.Width = 150;
            // 
            // Descripcion_Producto
            // 
            this.Descripcion_Producto.HeaderText = "Descripcion_Producto";
            this.Descripcion_Producto.MinimumWidth = 8;
            this.Descripcion_Producto.Name = "Descripcion_Producto";
            this.Descripcion_Producto.ReadOnly = true;
            this.Descripcion_Producto.Width = 150;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio_Venta";
            this.Precio_Venta.MinimumWidth = 8;
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.ReadOnly = true;
            this.Precio_Venta.Width = 150;
            // 
            // btnLimpiarTab2
            // 
            this.btnLimpiarTab2.FlatAppearance.BorderSize = 0;
            this.btnLimpiarTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarTab2.ForeColor = System.Drawing.Color.Azure;
            this.btnLimpiarTab2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarTab2.IconColor = System.Drawing.Color.Azure;
            this.btnLimpiarTab2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarTab2.IconSize = 32;
            this.btnLimpiarTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarTab2.Location = new System.Drawing.Point(1060, 277);
            this.btnLimpiarTab2.Name = "btnLimpiarTab2";
            this.btnLimpiarTab2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLimpiarTab2.Size = new System.Drawing.Size(234, 44);
            this.btnLimpiarTab2.TabIndex = 58;
            this.btnLimpiarTab2.Text = "Limpiar";
            this.btnLimpiarTab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarTab2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarTab2.UseVisualStyleBackColor = true;
            this.btnLimpiarTab2.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Azure;
            this.label16.Location = new System.Drawing.Point(62, 240);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 57;
            this.label16.Text = "Buscar por: ";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(70, 284);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(201, 28);
            this.comboBoxBusqueda.TabIndex = 56;
            // 
            // btnBuscarReportesFiltro
            // 
            this.btnBuscarReportesFiltro.FlatAppearance.BorderSize = 0;
            this.btnBuscarReportesFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReportesFiltro.ForeColor = System.Drawing.Color.Azure;
            this.btnBuscarReportesFiltro.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.btnBuscarReportesFiltro.IconColor = System.Drawing.Color.Azure;
            this.btnBuscarReportesFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReportesFiltro.IconSize = 32;
            this.btnBuscarReportesFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReportesFiltro.Location = new System.Drawing.Point(748, 275);
            this.btnBuscarReportesFiltro.Name = "btnBuscarReportesFiltro";
            this.btnBuscarReportesFiltro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscarReportesFiltro.Size = new System.Drawing.Size(225, 44);
            this.btnBuscarReportesFiltro.TabIndex = 55;
            this.btnBuscarReportesFiltro.Text = "Buscar";
            this.btnBuscarReportesFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReportesFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReportesFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarReportesFiltro.Click += new System.EventHandler(this.btnBuscarReportesFiltro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 68);
            this.panel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(1050, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(368, 42);
            this.label13.TabIndex = 65;
            this.label13.Text = "REPORTES FACTURAS";
            // 
            // Detalle_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 726);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detalle_Factura";
            this.Text = "Detalle_Factura";
            this.Load += new System.EventHandler(this.Detalle_Factura_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosDetalleFacutra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Facturacion.ResumeLayout(false);
            this.Facturacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaReportesFacturas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.TextBox textCedulaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGrillaProductosDetalleFacutra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBuscarFactura;
        private System.Windows.Forms.TextBox textIva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textCambio;
        private System.Windows.Forms.TextBox textDescuento;
        private System.Windows.Forms.TextBox textMontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinal;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnLimpiarTab2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscarReportesFiltro;
        private System.Windows.Forms.DataGridView DataGrillaReportesFacturas;
        private FontAwesome.Sharp.IconButton DescargarExcel;
        private System.Windows.Forms.TextBox textBoxBusquedaFiltro;
        private FontAwesome.Sharp.IconButton btnBuscarPorFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Facturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.TextBox textBoxTotalGenerado;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton BtnGenerarPdf;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.GroupBox Facturacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFechaFacturacion;
        private System.Windows.Forms.TextBox textNombreEmpleado;
        private System.Windows.Forms.TextBox textCedulaEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}