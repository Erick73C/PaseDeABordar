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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lisviewPasagerosFaltantes = new System.Windows.Forms.ListView();
            this.btnCheckInRealizado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(39, 56);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(229, 22);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(39, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(39, 228);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(229, 22);
            this.txtAsiento.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(53, 278);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(192, 40);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asiento";
            // 
            // lisviewPasagerosFaltantes
            // 
            this.lisviewPasagerosFaltantes.HideSelection = false;
            this.lisviewPasagerosFaltantes.Location = new System.Drawing.Point(375, 56);
            this.lisviewPasagerosFaltantes.Name = "lisviewPasagerosFaltantes";
            this.lisviewPasagerosFaltantes.Size = new System.Drawing.Size(413, 307);
            this.lisviewPasagerosFaltantes.TabIndex = 7;
            this.lisviewPasagerosFaltantes.UseCompatibleStateImageBehavior = false;
            this.lisviewPasagerosFaltantes.SelectedIndexChanged += new System.EventHandler(this.lisviewPasagerosFaltantes_SelectedIndexChanged);
            // 
            // btnCheckInRealizado
            // 
            this.btnCheckInRealizado.Location = new System.Drawing.Point(53, 338);
            this.btnCheckInRealizado.Name = "btnCheckInRealizado";
            this.btnCheckInRealizado.Size = new System.Drawing.Size(192, 40);
            this.btnCheckInRealizado.TabIndex = 8;
            this.btnCheckInRealizado.Text = "CheckIn";
            this.btnCheckInRealizado.UseVisualStyleBackColor = true;
            this.btnCheckInRealizado.Click += new System.EventHandler(this.btnCheckInRealizado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pasageros faltantes ";
            // 
            // frmChekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckInRealizado);
            this.Controls.Add(this.lisviewPasagerosFaltantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Name = "frmChekar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmChekar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lisviewPasagerosFaltantes;
        private System.Windows.Forms.Button btnCheckInRealizado;
        private System.Windows.Forms.Label label4;
    }
}

