namespace Ejercicio_2
{
	partial class ejercicio2
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
			this.lstLetras = new System.Windows.Forms.ListBox();
			this.btnMostrae = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstLetras
			// 
			this.lstLetras.FormattingEnabled = true;
			this.lstLetras.Location = new System.Drawing.Point(23, 23);
			this.lstLetras.Name = "lstLetras";
			this.lstLetras.Size = new System.Drawing.Size(129, 212);
			this.lstLetras.TabIndex = 0;
			// 
			// btnMostrae
			// 
			this.btnMostrae.Location = new System.Drawing.Point(41, 253);
			this.btnMostrae.Name = "btnMostrae";
			this.btnMostrae.Size = new System.Drawing.Size(92, 32);
			this.btnMostrae.TabIndex = 1;
			this.btnMostrae.Text = "Mostrar";
			this.btnMostrae.UseVisualStyleBackColor = true;
			this.btnMostrae.Click += new System.EventHandler(this.btnMostrae_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(188, 317);
			this.Controls.Add(this.btnMostrae);
			this.Controls.Add(this.lstLetras);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstLetras;
		private System.Windows.Forms.Button btnMostrae;
	}
}

