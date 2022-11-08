namespace Presentacion_GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnErroMessage = new FontAwesome.Sharp.IconButton();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 710);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(275, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(275, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(279, 320);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 40);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 38;
            this.iconPictureBox2.Location = new System.Drawing.Point(279, 407);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(38, 40);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnErroMessage);
            this.panel3.Controls.Add(this.txtContraseña);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.btnEmpleado);
            this.panel3.Controls.Add(this.iconPictureBox3);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(451, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 685);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnErroMessage
            // 
            this.btnErroMessage.FlatAppearance.BorderSize = 0;
            this.btnErroMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErroMessage.ForeColor = System.Drawing.Color.Black;
            this.btnErroMessage.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btnErroMessage.IconColor = System.Drawing.Color.Red;
            this.btnErroMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnErroMessage.IconSize = 32;
            this.btnErroMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErroMessage.Location = new System.Drawing.Point(269, 457);
            this.btnErroMessage.Name = "btnErroMessage";
            this.btnErroMessage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnErroMessage.Size = new System.Drawing.Size(251, 67);
            this.btnErroMessage.TabIndex = 10;
            this.btnErroMessage.Text = "Error Message";
            this.btnErroMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErroMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnErroMessage.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(338, 415);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(373, 26);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(338, 322);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(373, 26);
            this.txtUsuario.TabIndex = 7;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnEmpleado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.IconSize = 32;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(495, 530);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(176, 70);
            this.btnEmpleado.TabIndex = 6;
            this.btnEmpleado.Text = "Ingresar";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox3.BackgroundImage")));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 185;
            this.iconPictureBox3.Location = new System.Drawing.Point(386, 65);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(394, 185);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalir.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalir.IconSize = 40;
            this.btnSalir.Location = new System.Drawing.Point(959, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private FontAwesome.Sharp.IconButton btnErroMessage;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
    }
}