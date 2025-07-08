namespace PaseDeABordar
{
    partial class frmChekar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lisviewPasagerosFaltantes = new System.Windows.Forms.ListView();
            this.btnCheckInRealizado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbVuelos = new System.Windows.Forms.ComboBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(217, 166);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(229, 30);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(163, 323);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.Location = new System.Drawing.Point(217, 477);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(229, 30);
            this.txtAsiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asiento:";
            // 
            // lisviewPasagerosFaltantes
            // 
            this.lisviewPasagerosFaltantes.BackColor = System.Drawing.Color.MediumOrchid;
            this.lisviewPasagerosFaltantes.HideSelection = false;
            this.lisviewPasagerosFaltantes.Location = new System.Drawing.Point(1075, 384);
            this.lisviewPasagerosFaltantes.Name = "lisviewPasagerosFaltantes";
            this.lisviewPasagerosFaltantes.Size = new System.Drawing.Size(684, 537);
            this.lisviewPasagerosFaltantes.TabIndex = 7;
            this.lisviewPasagerosFaltantes.UseCompatibleStateImageBehavior = false;
            this.lisviewPasagerosFaltantes.SelectedIndexChanged += new System.EventHandler(this.lisviewPasagerosFaltantes_SelectedIndexChanged);
            // 
            // btnCheckInRealizado
            // 
            this.btnCheckInRealizado.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCheckInRealizado.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInRealizado.ForeColor = System.Drawing.Color.White;
            this.btnCheckInRealizado.Location = new System.Drawing.Point(339, 30);
            this.btnCheckInRealizado.Name = "btnCheckInRealizado";
            this.btnCheckInRealizado.Size = new System.Drawing.Size(274, 77);
            this.btnCheckInRealizado.TabIndex = 8;
            this.btnCheckInRealizado.Text = "Check-In";
            this.btnCheckInRealizado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheckInRealizado.UseVisualStyleBackColor = false;
            this.btnCheckInRealizado.Click += new System.EventHandler(this.btnCheckInRealizado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 94);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pasajeros Faltantes ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtAsiento);
            this.panel1.Location = new System.Drawing.Point(279, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 547);
            this.panel1.TabIndex = 10;
            // 
            // cmbVuelos
            // 
            this.cmbVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbVuelos.FormattingEnabled = true;
            this.cmbVuelos.Location = new System.Drawing.Point(234, 104);
            this.cmbVuelos.Name = "cmbVuelos";
            this.cmbVuelos.Size = new System.Drawing.Size(235, 25);
            this.cmbVuelos.TabIndex = 15;
            this.cmbVuelos.SelectedIndexChanged += new System.EventHandler(this.cmbVuelos_SelectedIndexChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PaseDeABordar.Properties.Resources.icons8_tarjeta_de_identificación_de_trabajador_48;
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(78, 64);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(168, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 67);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PaseDeABordar.Properties.Resources.icons8_asiento_80;
            this.pictureBox7.Location = new System.Drawing.Point(45, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(78, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(168, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 67);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PaseDeABordar.Properties.Resources.icons8_nombre_100;
            this.pictureBox6.Location = new System.Drawing.Point(45, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(168, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 67);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PaseDeABordar.Properties.Resources.icons8_contador_distribuido_48;
            this.pictureBox5.Location = new System.Drawing.Point(45, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, -12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 107);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datos:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2158, 120);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PaseDeABordar.Properties.Resources.icons8_menú_64;
            this.pictureBox4.Location = new System.Drawing.Point(1799, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PaseDeABordar.Properties.Resources.icons8_ayuda_48;
            this.pictureBox3.Location = new System.Drawing.Point(1670, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PaseDeABordar.Properties.Resources.icons8_avión_94;
            this.pictureBox2.Location = new System.Drawing.Point(56, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox9.Image = global::PaseDeABordar.Properties.Resources.icons8_registrarse_48;
            this.pictureBox9.Location = new System.Drawing.Point(378, 43);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(61, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PaseDeABordar.Properties.Resources.photo_1516889782132_fb580815f8f9;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Controls.Add(this.btnImprimir);
            this.panel6.Controls.Add(this.pictureBox9);
            this.panel6.Controls.Add(this.btnCheckInRealizado);
            this.panel6.Location = new System.Drawing.Point(279, 788);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(652, 133);
            this.panel6.TabIndex = 14;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox8.Image = global::PaseDeABordar.Properties.Resources.icons8_impresora_48;
            this.pictureBox8.Location = new System.Drawing.Point(78, 43);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(61, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnImprimir.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(37, 30);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(274, 77);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 91);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ingresa el numero de vuelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.groupBox1.Controls.Add(this.cmbVuelos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1075, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // frmChekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lisviewPasagerosFaltantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChekar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmChekar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lisviewPasagerosFaltantes;
        private System.Windows.Forms.Button btnCheckInRealizado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ComboBox cmbVuelos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

