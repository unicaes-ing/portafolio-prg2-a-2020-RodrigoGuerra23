using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class ejercicio1 : Form
	{
		public ejercicio1()
		{
			InitializeComponent();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			int n;
			if (int.TryParse(txtTablas.Text, out n))
			{
				listBox1.Items.Clear();
				for (int i = 0; i <= 10; i++)
				{
					listBox1.Items.Add(n + "*" + i + "=" + n * i);
				}
			}
			else
			{
				MessageBox.Show("Ingrese un numero");
			}
		}
	}
}
