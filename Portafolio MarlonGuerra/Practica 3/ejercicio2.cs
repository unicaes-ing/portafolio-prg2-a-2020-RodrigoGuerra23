using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
	public partial class ejercicio2 : Form
	{
		public ejercicio2()
		{
			InitializeComponent();
		}

		private void btnMostrae_Click(object sender, EventArgs e)
		{
			lstLetras.ForeColor = Color.BlueViolet;
			lstLetras.Items.Clear();
			for (char letra = 'A'; letra <= 'Z'  ; letra++)
			{
				lstLetras.Items.Add(letra);
			}
			lstLetras.Items.Insert(14, 'Ñ');
		}
	}
}
