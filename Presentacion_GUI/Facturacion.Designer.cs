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
            this.textFecha = new System.Windows.Forms.TextBox();
            this.DataGrillaProductosVenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnErroMessage = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnNuevoCliente = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.ComboBoxProductos = new System.Windows.Forms.ComboBox();
            this.ComboBoxCantidad = new System.Windows.Forms.NumericUpDown();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFecha = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFecha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(1084, 24);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(234, 26);
            this.textFecha.TabIndex = 17;
            // 
            // DataGrillaProductosVenta
            // 
            this.DataGrillaProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrillaProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.DataGrillaProductosVenta.Location = new System.Drawing.Point(33, 286);
            this.DataGrillaProductosVenta.Name = "DataGrillaProductosVenta";
            this.DataGrillaProductosVenta.ReadOnly = true;
            this.DataGrillaProductosVenta.RowHeadersWidth = 62;
            this.DataGrillaProductosVenta.RowTemplate.Height = 28;
            this.DataGrillaProductosVenta.Size = new System.Drawing.Size(923, 322);
            this.DataGrillaProductosVenta.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "P. Unitario";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Importe";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
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
            this.btnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardarVenta.IconColor = System.Drawing.Color.Azure;
            this.btnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVenta.IconSize = 32;
            this.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.Location = new System.Drawing.Point(407, 617);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(183, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 24);
            this.listBox1.TabIndex = 1;
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
            this.btnErroMessage.Location = new System.Drawing.Point(44, 81);
            this.btnErroMessage.Name = "btnErroMessage";
            this.btnErroMessage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnErroMessage.Size = new System.Drawing.Size(131, 44);
            this.btnErroMessage.TabIndex = 11;
            this.btnErroMessage.Text = "Cliente";
            this.btnErroMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErroMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnErroMessage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 90);
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
            this.btnBuscar.Location = new System.Drawing.Point(468, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscar.Size = new System.Drawing.Size(135, 44);
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
            this.btnNuevoCliente.Location = new System.Drawing.Point(842, 81);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevoCliente.Size = new System.Drawing.Size(124, 44);
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
            this.label2.Location = new System.Drawing.Point(46, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(46, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.btnAñadir.Location = new System.Drawing.Point(539, 154);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAñadir.Size = new System.Drawing.Size(135, 44);
            this.btnAñadir.TabIndex = 25;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(298, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Medida";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ComboBoxUnidades
            // 
            this.ComboBoxUnidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnidades.FormattingEnabled = true;
            this.ComboBoxUnidades.Items.AddRange(new object[] {
            "UNIDAD",
            "SIXPACK",
            "DOCEPACK",
            "CAJA (24 Unds)",
            "CANASTA (30 Unds)"});
            this.ComboBoxUnidades.Location = new System.Drawing.Point(374, 230);
            this.ComboBoxUnidades.Name = "ComboBoxUnidades";
            this.ComboBoxUnidades.Size = new System.Drawing.Size(137, 28);
            this.ComboBoxUnidades.TabIndex = 41;
            this.ComboBoxUnidades.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUnidades_SelectedIndexChanged);
            // 
            // ComboBoxProductos
            // 
            this.ComboBoxProductos.FormattingEnabled = true;
            this.ComboBoxProductos.Location = new System.Drawing.Point(149, 166);
            this.ComboBoxProductos.Name = "ComboBoxProductos";
            this.ComboBoxProductos.Size = new System.Drawing.Size(350, 28);
            this.ComboBoxProductos.TabIndex = 42;
            // 
            // ComboBoxCantidad
            // 
            this.ComboBoxCantidad.Location = new System.Drawing.Point(137, 232);
            this.ComboBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ComboBoxCantidad.Name = "ComboBoxCantidad";
            this.ComboBoxCantidad.Size = new System.Drawing.Size(120, 26);
            this.ComboBoxCantidad.TabIndex = 49;
            this.ComboBoxCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ComboBoxCantidad.ValueChanged += new System.EventHandler(this.ComboBoxCantidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(22, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Iva:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total a Pagar: ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(151, 38);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(151, 26);
            this.txtSubTotal.TabIndex = 30;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(151, 90);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(151, 26);
            this.txtIva.TabIndex = 31;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(151, 191);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(149, 26);
            this.txtTotalPagar.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(22, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Efectivo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(182, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cambio: ";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(23, 279);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(126, 26);
            this.txtEfectivo.TabIndex = 36;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(186, 279);
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
            this.btnCalcular.Location = new System.Drawing.Point(87, 326);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalcular.Size = new System.Drawing.Size(166, 40);
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
            this.comboBoxDescuento.Location = new System.Drawing.Point(151, 138);
            this.comboBoxDescuento.Name = "comboBoxDescuento";
            this.comboBoxDescuento.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDescuento.TabIndex = 50;
            this.comboBoxDescuento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescuento_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.iconFecha);
            this.panel2.Controls.Add(this.ComboBoxCantidad);
            this.panel2.Controls.Add(this.ComboBoxProductos);
            this.panel2.Controls.Add(this.ComboBoxUnidades);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnAñadir);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnNuevoCliente);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnErroMessage);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(-6, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 452);
            this.panel2.TabIndex = 52;
            // 
            // iconFecha
            // 
            this.iconFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconFecha.ForeColor = System.Drawing.Color.Azure;
            this.iconFecha.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconFecha.IconColor = System.Drawing.Color.Azure;
            this.iconFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFecha.Location = new System.Drawing.Point(1026, 27);
            this.iconFecha.Name = "iconFecha";
            this.iconFecha.Size = new System.Drawing.Size(32, 32);
            this.iconFecha.TabIndex = 50;
            this.iconFecha.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboBoxDescuento);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtCambio);
            this.panel1.Controls.Add(this.txtEfectivo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTotalPagar);
            this.panel1.Controls.Add(this.txtIva);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(997, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 373);
            this.panel1.TabIndex = 51;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1351, 669);
            this.Controls.Add(this.DataGrillaProductosVenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrillaProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFecha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.DataGridView DataGrillaProductosVenta;
        private FontAwesome.Sharp.IconButton btnGuardarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton btnErroMessage;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnNuevoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxUnidades;
        private System.Windows.Forms.ComboBox ComboBoxProductos;
        private System.Windows.Forms.NumericUpDown ComboBoxCantidad;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconFecha;
    }
}