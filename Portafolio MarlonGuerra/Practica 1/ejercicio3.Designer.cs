namespace Ejercicio_3
{
    partial class Inversiones
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textInversionista1 = new System.Windows.Forms.TextBox();
            this.textInversionista2 = new System.Windows.Forms.TextBox();
            this.textInversionista3 = new System.Windows.Forms.TextBox();
            this.textPorcentaje1 = new System.Windows.Forms.TextBox();
            this.textPorcentaje2 = new System.Windows.Forms.TextBox();
            this.textPorcentaje3 = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentajes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total de inversion:";
            // 
            // textInversionista1
            // 
            this.textInversionista1.Location = new System.Drawing.Point(34, 53);
            this.textInversionista1.Name = "textInversionista1";
            this.textInversionista1.Size = new System.Drawing.Size(100, 20);
            this.textInversionista1.TabIndex = 6;
            // 
            // textInversionista2
            // 
            this.textInversionista2.Location = new System.Drawing.Point(34, 95);
            this.textInversionista2.Name = "textInversionista2";
            this.textInversionista2.Size = new System.Drawing.Size(100, 20);
            this.textInversionista2.TabIndex = 7;
            // 
            // textInversionista3
            // 
            this.textInversionista3.Location = new System.Drawing.Point(34, 142);
            this.textInversionista3.Name = "textInversionista3";
            this.textInversionista3.Size = new System.Drawing.Size(100, 20);
            this.textInversionista3.TabIndex = 8;
            // 
            // textPorcentaje1
            // 
            this.textPorcentaje1.Location = new System.Drawing.Point(171, 53);
            this.textPorcentaje1.Name = "textPorcentaje1";
            this.textPorcentaje1.Size = new System.Drawing.Size(100, 20);
            this.textPorcentaje1.TabIndex = 9;
            // 
            // textPorcentaje2
            // 
            this.textPorcentaje2.Location = new System.Drawing.Point(171, 99);
            this.textPorcentaje2.Name = "textPorcentaje2";
            this.textPorcentaje2.Size = new System.Drawing.Size(100, 20);
            this.textPorcentaje2.TabIndex = 10;
            // 
            // textPorcentaje3
            // 
            this.textPorcentaje3.Location = new System.Drawing.Point(171, 142);
            this.textPorcentaje3.Name = "textPorcentaje3";
            this.textPorcentaje3.Size = new System.Drawing.Size(100, 20);
            this.textPorcentaje3.TabIndex = 11;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(34, 218);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(115, 277);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(196, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 335);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textPorcentaje3);
            this.Controls.Add(this.textPorcentaje2);
            this.Controls.Add(this.textPorcentaje1);
            this.Controls.Add(this.textInversionista3);
            this.Controls.Add(this.textInversionista2);
            this.Controls.Add(this.textInversionista1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inversiones";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textInversionista1;
        private System.Windows.Forms.TextBox textInversionista2;
        private System.Windows.Forms.TextBox textInversionista3;
        private System.Windows.Forms.TextBox textPorcentaje1;
        private System.Windows.Forms.TextBox textPorcentaje2;
        private System.Windows.Forms.TextBox textPorcentaje3;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

