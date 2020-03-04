using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
	public partial class ejercicio3 : Form
	{
		public ejercicio3()
		{
			InitializeComponent();
		}

		private void btnLanzar_Click(object sender, EventArgs e)
		{
			Random n = new Random();
			int a = 0;
			lstNumero.Items.Clear();
			for (int i = 1; i <= 5000; i++)
			{
				int num = n.Next(1, 7);
				lstNumero.Items.Add(num);
				if (num == 6) a++;
			}
			MessageBox.Show("Se contaron" +" "+ a+" " + "el numero 6");
		}
	}
}
