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
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrillaProductosVenta = new System.Windows.Forms.DataGridView();
            this.btnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.btnErroMessage = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.ComboBoxProductos = new System.Windows.Forms.ComboBox();
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
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            this.comboBoxDescuento = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.ComboBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFecha)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).BeginInit();
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
            this.DataGrillaProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrillaProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            this.DataGrillaProductosVenta.Location = new System.Drawing.Point(44, 416);
            this.DataGrillaProductosVenta.Name = "DataGrillaProductosVenta";
            this.DataGrillaProductosVenta.ReadOnly = true;
            this.DataGrillaProductosVenta.RowHeadersWidth = 62;
            this.DataGrillaProductosVenta.RowTemplate.Height = 28;
            this.DataGrillaProductosVenta.Size = new System.Drawing.Size(779, 242);
            this.DataGrillaProductosVenta.TabIndex = 19;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardarVenta.IconColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVenta.IconSize = 32;
            this.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.Location = new System.Drawing.Point(374, 691);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarVenta.Size = new System.Drawing.Size(191, 40);
            this.btnGuardarVenta.TabIndex = 39;
            this.btnGuardarVenta.Text = "Registrar Venta";
            this.btnGuardarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarVenta.UseVisualStyleBackColor = false;
            this.btnGuardarVenta.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnErroMessage
            // 
            this.btnErroMessage.FlatAppearance.BorderSize = 0;
            this.btnErroMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErroMessage.ForeColor = System.Drawing.Color.Azure;
            this.btnErroMessage.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnErroMessage.IconColor = System.Drawing.Color.Azure;
            this.btnErroMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnErroMessage.IconSize = 32;
            this.btnErroMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErroMessage.Location = new System.Drawing.Point(652, 191);
            this.btnErroMessage.Name = "btnErroMessage";
            this.btnErroMessage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnErroMessage.Size = new System.Drawing.Size(147, 44);
            this.btnErroMessage.TabIndex = 11;
            this.btnErroMessage.Text = "Cliente";
            this.btnErroMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErroMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnErroMessage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(824, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 12;
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
            this.btnBuscar.Location = new System.Drawing.Point(646, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscar.Size = new System.Drawing.Size(146, 44);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Azure;
            this.btnNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNuevoCliente.IconColor = System.Drawing.Color.Azure;
            this.btnNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCliente.IconSize = 32;
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(1093, 151);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevoCliente.Size = new System.Drawing.Size(149, 44);
            this.btnNuevoCliente.TabIndex = 14;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(81, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Producto";
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.Azure;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAñadir.IconColor = System.Drawing.Color.Azure;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 32;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(434, 317);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAñadir.Size = new System.Drawing.Size(161, 44);
            this.btnAñadir.TabIndex = 25;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ComboBoxProductos
            // 
            this.ComboBoxProductos.FormattingEnabled = true;
            this.ComboBoxProductos.Location = new System.Drawing.Point(280, 193);
            this.ComboBoxProductos.Name = "ComboBoxProductos";
            this.ComboBoxProductos.Size = new System.Drawing.Size(264, 28);
            this.ComboBoxProductos.TabIndex = 42;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(1002, 28);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(234, 26);
            this.textFecha.TabIndex = 17;
            this.textFecha.TextChanged += new System.EventHandler(this.textFecha_TextChanged);
            // 
            // iconFecha
            // 
            this.iconFecha.BackColor = System.Drawing.Color.Transparent;
            this.iconFecha.ForeColor = System.Drawing.Color.Azure;
            this.iconFecha.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconFecha.IconColor = System.Drawing.Color.Azure;
            this.iconFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFecha.Location = new System.Drawing.Point(946, 28);
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
            this.label4.Location = new System.Drawing.Point(900, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(38, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(900, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Iva:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(38, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total a Pagar: ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(1029, 354);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(151, 26);
            this.txtSubTotal.TabIndex = 30;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(1029, 410);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(151, 26);
            this.txtIva.TabIndex = 31;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(167, 71);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(149, 26);
            this.txtTotalPagar.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(38, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Efectivo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(198, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cambio: ";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(39, 157);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(126, 26);
            this.txtEfectivo.TabIndex = 36;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(202, 157);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(126, 26);
            this.txtCambio.TabIndex = 37;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Azure;
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcular.IconColor = System.Drawing.Color.Azure;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 32;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(103, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalcular.Size = new System.Drawing.Size(213, 40);
            this.btnCalcular.TabIndex = 38;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // comboBoxDescuento
            // 
            this.comboBoxDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescuento.FormattingEnabled = true;
            this.comboBoxDescuento.Items.AddRange(new object[] {
            "4%",
            "6%",
            "8%",
            "10%",
            "12%",
            "14%",
            "16%"});
            this.comboBoxDescuento.Location = new System.Drawing.Point(167, 18);
            this.comboBoxDescuento.Name = "comboBoxDescuento";
            this.comboBoxDescuento.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDescuento.TabIndex = 50;
            this.comboBoxDescuento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescuento_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 26);
            this.textBox2.TabIndex = 52;
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
            this.iconButton1.Location = new System.Drawing.Point(70, 238);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(171, 44);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Azure;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.Azure;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(70, 123);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(171, 44);
            this.iconButton2.TabIndex = 55;
            this.iconButton2.Text = "Empleado";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 26);
            this.textBox3.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboBoxClientes);
            this.panel1.Controls.Add(this.textBoxIdProducto);
            this.panel1.Controls.Add(this.ComboBoxCantidad);
            this.panel1.Controls.Add(this.ComboBoxUnidades);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btnNuevoCliente);
            this.panel1.Controls.Add(this.btnErroMessage);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.iconFecha);
            this.panel1.Controls.Add(this.textFecha);
            this.panel1.Controls.Add(this.ComboBoxProductos);
            this.panel1.Controls.Add(this.txtIva);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 447);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(864, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 269);
            this.panel2.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(862, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 286);
            this.panel3.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.comboBoxDescuento);
            this.panel4.Controls.Add(this.btnCalcular);
            this.panel4.Controls.Add(this.txtCambio);
            this.panel4.Controls.Add(this.txtEfectivo);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtTotalPagar);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(864, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 272);
            this.panel4.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(81, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cantidad";
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
            this.ComboBoxUnidades.Location = new System.Drawing.Point(406, 256);
            this.ComboBoxUnidades.Name = "ComboBoxUnidades";
            this.ComboBoxUnidades.Size = new System.Drawing.Size(140, 28);
            this.ComboBoxUnidades.TabIndex = 60;
            // 
            // ComboBoxCantidad
            // 
            this.ComboBoxCantidad.Location = new System.Drawing.Point(242, 311);
            this.ComboBoxCantidad.Name = "ComboBoxCantidad";
            this.ComboBoxCantidad.Size = new System.Drawing.Size(132, 26);
            this.ComboBoxCantidad.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProducto";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Eliminar";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(240, 193);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(34, 26);
            this.textBoxIdProducto.TabIndex = 62;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(824, 196);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(222, 28);
            this.comboBoxClientes.TabIndex = 63;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 742);
            this.Controls.Add(this.DataGrillaProductosVenta);
            this.Controls.Add(this.panel4);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrillaProductosVenta;
        private FontAwesome.Sharp.IconButton btnGuardarVenta;
        private FontAwesome.Sharp.IconButton btnErroMessage;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.ComboBox ComboBoxProductos;
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
        private FontAwesome.Sharp.IconButton btnCalcular;
        private System.Windows.Forms.ComboBox comboBoxDescuento;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxUnidades;
        private System.Windows.Forms.NumericUpDown ComboBoxCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.ComboBox comboBoxClientes;
    }
}