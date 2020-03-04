using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
	public partial class ejercicio4 : Form
	{
		public ejercicio4()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.Size = new Size(210, 220);
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ScrollBars = ScrollBars.None;
			dataGridView1.ColumnCount = 10;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dataGridView1.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dataGridView1.Rows[f].Cells[c].Value = r.Next(10, 100);
                    dataGridView1.Rows[f].Cells[c].Style.BackColor = Color.Blue;
                }
            }
            dataGridView1.ClearSelection();
        }

		private void tbnBuscar_Click(object sender, EventArgs e)
		{
            try
            {
                int num = Convert.ToInt32(txtNumBuscado.Text);
                for (int f = 0; f < 10; f++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dataGridView1.Rows[f].Cells[i].Value.Equals(num))
                        {
                            dataGridView1.Rows[f].Cells[i].Style.BackColor = Color.Cyan;
                        }
                        else
                        {
                            dataGridView1.Rows[f].Cells[i].Style.BackColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el número");
            }
        }
	}
}
