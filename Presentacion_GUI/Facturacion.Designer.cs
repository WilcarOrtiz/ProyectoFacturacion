namespace Presentacion_GUI
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrillaProductosVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.textBoxBusquedaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.iconFecha = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.comboBoxDescuento = new System.Windows.Forms.ComboBox();
            this.textBoxBusquedaProducto = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textNombreProducto = new System.Windows.Forms.TextBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.ComboBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdEmpleado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFecha)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // DataGrillaProductosVenta
            // 
            this.DataGrillaProductosVenta.AllowUserToAddRows = false;
            this.DataGrillaProductosVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DataGrillaProductosVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrillaProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrillaProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Column5,
            this.Precio,
            this.Unidades,
            this.Importe,
            this.Column7});
            this.DataGrillaProductosVenta.Location = new System.Drawing.Point(31, 400);
            this.DataGrillaProductosVenta.Name = "DataGrillaProductosVenta";
            this.DataGrillaProductosVenta.ReadOnly = true;
            this.DataGrillaProductosVenta.RowHeadersWidth = 62;
            this.DataGrillaProductosVenta.RowTemplate.Height = 28;
            this.DataGrillaProductosVenta.Size = new System.Drawing.Size(810, 234);
            this.DataGrillaProductosVenta.TabIndex = 19;
            this.DataGrillaProductosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrillaProductosVenta_CellClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 8;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 150;
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
            // Column7
            // 
            this.Column7.HeaderText = "Eliminar";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.Green;
            this.btnGuardarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardarVenta.IconColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVenta.IconSize = 32;
            this.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.Location = new System.Drawing.Point(325, 660);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarVenta.Size = new System.Drawing.Size(234, 40);
            this.btnGuardarVenta.TabIndex = 39;
            this.btnGuardarVenta.Text = "Registrar Venta";
            this.btnGuardarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarVenta.UseVisualStyleBackColor = false;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // textBoxBusquedaCliente
            // 
            this.textBoxBusquedaCliente.Location = new System.Drawing.Point(1156, 198);
            this.textBoxBusquedaCliente.Name = "textBoxBusquedaCliente";
            this.textBoxBusquedaCliente.Size = new System.Drawing.Size(222, 26);
            this.textBoxBusquedaCliente.TabIndex = 12;
            this.textBoxBusquedaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusquedaCliente_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Azure;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Azure;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(868, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscar.Size = new System.Drawing.Size(228, 44);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.Azure;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAñadir.IconColor = System.Drawing.Color.Azure;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 32;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(479, 321);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAñadir.Size = new System.Drawing.Size(197, 44);
            this.btnAñadir.TabIndex = 25;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(70, 25);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(234, 26);
            this.textFecha.TabIndex = 17;
            // 
            // iconFecha
            // 
            this.iconFecha.BackColor = System.Drawing.Color.Transparent;
            this.iconFecha.ForeColor = System.Drawing.Color.Azure;
            this.iconFecha.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconFecha.IconColor = System.Drawing.Color.Azure;
            this.iconFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFecha.Location = new System.Drawing.Point(29, 23);
            this.iconFecha.Name = "iconFecha";
            this.iconFecha.Size = new System.Drawing.Size(32, 32);
            this.iconFecha.TabIndex = 50;
            this.iconFecha.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(999, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(62, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(63, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Iva:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(54, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total a Pagar: ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(1160, 398);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(151, 26);
            this.txtSubTotal.TabIndex = 30;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(221, 3);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(151, 26);
            this.txtIva.TabIndex = 31;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(227, 111);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(149, 26);
            this.txtTotalPagar.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(65, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Efectivo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(227, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cambio: ";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(67, 200);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(126, 26);
            this.txtEfectivo.TabIndex = 36;
            this.txtEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyDown);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(234, 200);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(126, 26);
            this.txtCambio.TabIndex = 37;
            // 
            // comboBoxDescuento
            // 
            this.comboBoxDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescuento.FormattingEnabled = true;
            this.comboBoxDescuento.Items.AddRange(new object[] {
            "0%",
            "4%",
            "6%",
            "8%",
            "10%",
            "12%",
            "14%",
            "16%"});
            this.comboBoxDescuento.Location = new System.Drawing.Point(225, 55);
            this.comboBoxDescuento.Name = "comboBoxDescuento";
            this.comboBoxDescuento.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDescuento.TabIndex = 50;
            this.comboBoxDescuento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescuento_SelectedIndexChanged);
            // 
            // textBoxBusquedaProducto
            // 
            this.textBoxBusquedaProducto.Location = new System.Drawing.Point(120, 164);
            this.textBoxBusquedaProducto.Name = "textBoxBusquedaProducto";
            this.textBoxBusquedaProducto.Size = new System.Drawing.Size(147, 26);
            this.textBoxBusquedaProducto.TabIndex = 52;
            this.textBoxBusquedaProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Azure;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Azure;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(115, 111);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(132, 44);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(120, 252);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(134, 26);
            this.textBoxPrecio.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboBoxProductos);
            this.panel1.Controls.Add(this.iconFecha);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textNombreProducto);
            this.panel1.Controls.Add(this.textBoxIdCliente);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.comboBoxClientes);
            this.panel1.Controls.Add(this.textBoxIdProducto);
            this.panel1.Controls.Add(this.ComboBoxCantidad);
            this.panel1.Controls.Add(this.ComboBoxUnidades);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxBusquedaCliente);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.textBoxBusquedaProducto);
            this.panel1.Controls.Add(this.textFecha);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelIdEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 520);
            this.panel1.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(530, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 55);
            this.label12.TabIndex = 69;
            this.label12.Text = "FACTURACION";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(320, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Medida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(122, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Precio";
            // 
            // textNombreProducto
            // 
            this.textNombreProducto.Enabled = false;
            this.textNombreProducto.Location = new System.Drawing.Point(375, 164);
            this.textNombreProducto.Name = "textNombreProducto";
            this.textNombreProducto.ReadOnly = true;
            this.textNombreProducto.Size = new System.Drawing.Size(256, 26);
            this.textNombreProducto.TabIndex = 66;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Enabled = false;
            this.textBoxIdCliente.Location = new System.Drawing.Point(868, 198);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.ReadOnly = true;
            this.textBoxIdCliente.Size = new System.Drawing.Size(34, 26);
            this.textBoxIdCliente.TabIndex = 65;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Azure;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton3.IconColor = System.Drawing.Color.Azure;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(1147, 146);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(231, 44);
            this.iconButton3.TabIndex = 64;
            this.iconButton3.Text = "Cliente";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(908, 196);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(188, 28);
            this.comboBoxClientes.TabIndex = 63;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Enabled = false;
            this.textBoxIdProducto.Location = new System.Drawing.Point(330, 164);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.ReadOnly = true;
            this.textBoxIdProducto.Size = new System.Drawing.Size(34, 26);
            this.textBoxIdProducto.TabIndex = 62;
            // 
            // ComboBoxCantidad
            // 
            this.ComboBoxCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxCantidad.Location = new System.Drawing.Point(510, 252);
            this.ComboBoxCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ComboBoxCantidad.Name = "ComboBoxCantidad";
            this.ComboBoxCantidad.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxCantidad.TabIndex = 61;
            this.ComboBoxCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComboBoxUnidades
            // 
            this.ComboBoxUnidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnidades.FormattingEnabled = true;
            this.ComboBoxUnidades.Items.AddRange(new object[] {
            "UNIDAD",
            "CAJA (24 Unds)",
            "CANASTA (30 Unds)"});
            this.ComboBoxUnidades.Location = new System.Drawing.Point(318, 252);
            this.ComboBoxUnidades.Name = "ComboBoxUnidades";
            this.ComboBoxUnidades.Size = new System.Drawing.Size(140, 28);
            this.ComboBoxUnidades.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(503, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(326, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Producto";
            // 
            // labelIdEmpleado
            // 
            this.labelIdEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.labelIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelIdEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.labelIdEmpleado.Location = new System.Drawing.Point(89, 28);
            this.labelIdEmpleado.Name = "labelIdEmpleado";
            this.labelIdEmpleado.Size = new System.Drawing.Size(100, 19);
            this.labelIdEmpleado.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.comboBoxDescuento);
            this.panel2.Controls.Add(this.txtIva);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCambio);
            this.panel2.Controls.Add(this.txtEfectivo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTotalPagar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(942, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 247);
            this.panel2.TabIndex = 58;
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(120, 330);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(310, 28);
            this.comboBoxProductos.TabIndex = 71;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1441, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGrillaProductosVenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFecha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrillaProductosVenta;
        private FontAwesome.Sharp.IconButton btnGuardarVenta;
        private System.Windows.Forms.TextBox textBoxBusquedaCliente;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.TextBox textFecha;
        private FontAwesome.Sharp.IconPictureBox iconFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.ComboBox comboBoxDescuento;
        private System.Windows.Forms.TextBox textBoxBusquedaProducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxUnidades;
        private System.Windows.Forms.NumericUpDown ComboBoxCantidad;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textNombreProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.TextBox labelIdEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxProductos;
    }
}