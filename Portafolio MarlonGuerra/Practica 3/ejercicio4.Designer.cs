namespace Ejercicio_4
{
	partial class ejercicio4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnBuscar = new System.Windows.Forms.Button();
            this.txtNumBuscado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero a encontrar:";
            // 
            // tbnBuscar
            // 
            this.tbnBuscar.Location = new System.Drawing.Point(252, 324);
            this.tbnBuscar.Name = "tbnBuscar";
            this.tbnBuscar.Size = new System.Drawing.Size(86, 25);
            this.tbnBuscar.TabIndex = 2;
            this.tbnBuscar.Text = "Buscar";
            this.tbnBuscar.UseVisualStyleBackColor = true;
            this.tbnBuscar.Click += new System.EventHandler(this.tbnBuscar_Click);
            // 
            // txtNumBuscado
            // 
            this.txtNumBuscado.Location = new System.Drawing.Point(138, 324);
            this.txtNumBuscado.Name = "txtNumBuscado";
            this.txtNumBuscado.Size = new System.Drawing.Size(83, 20);
            this.txtNumBuscado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 370);
            this.Controls.Add(this.txtNumBuscado);
            this.Controls.Add(this.tbnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button tbnBuscar;
		private System.Windows.Forms.TextBox txtNumBuscado;
	}
}

