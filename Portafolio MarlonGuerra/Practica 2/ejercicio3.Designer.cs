namespace ejercicio_3
{
    partial class ejercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstde = new System.Windows.Forms.ListBox();
            this.lsta = new System.Windows.Forms.ListBox();
            this.txtlco = new System.Windows.Forms.TextBox();
            this.txtconv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca la longitud a convertir ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitud convertida";
            // 
            // lstde
            // 
            this.lstde.FormattingEnabled = true;
            this.lstde.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstde.Location = new System.Drawing.Point(30, 105);
            this.lstde.Name = "lstde";
            this.lstde.Size = new System.Drawing.Size(120, 95);
            this.lstde.TabIndex = 4;
            // 
            // lsta
            // 
            this.lsta.FormattingEnabled = true;
            this.lsta.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lsta.Location = new System.Drawing.Point(176, 105);
            this.lsta.Name = "lsta";
            this.lsta.Size = new System.Drawing.Size(120, 95);
            this.lsta.TabIndex = 5;
            // 
            // txtlco
            // 
            this.txtlco.Location = new System.Drawing.Point(196, 36);
            this.txtlco.Name = "txtlco";
            this.txtlco.Size = new System.Drawing.Size(100, 20);
            this.txtlco.TabIndex = 6;
            // 
            // txtconv
            // 
            this.txtconv.Location = new System.Drawing.Point(138, 228);
            this.txtconv.Name = "txtconv";
            this.txtconv.Size = new System.Drawing.Size(100, 20);
            this.txtconv.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtconv);
            this.Controls.Add(this.txtlco);
            this.Controls.Add(this.lsta);
            this.Controls.Add(this.lstde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstde;
        private System.Windows.Forms.ListBox lsta;
        private System.Windows.Forms.TextBox txtlco;
        private System.Windows.Forms.TextBox txtconv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

