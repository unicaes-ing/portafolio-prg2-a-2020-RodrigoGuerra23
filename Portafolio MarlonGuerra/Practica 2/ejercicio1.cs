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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConvertir_Click(object sender, EventArgs e)
		{
			try
			{
				int numero = Convert.ToInt32(textNumero.Text);
				string romano = "";
				if (numero >= 1 && numero <= 10)
				{
					if (numero == 1)
					{
						romano = "I";
					}
					else if (numero == 2)
					{
						romano = "II";
					}
					else if (numero == 3)
					{
						romano = "III";
					}
					else if (numero == 4)
					{
						romano = "IV";
					}
					else if (numero == 5)
					{
						romano = "V";
					}
					else if (numero == 6)
					{
						romano = "VI";
					}
					else if (numero == 7)
					{
						romano = "VII";
					}
					else if (numero == 8)
					{
						romano = "VIII";
					}
					else if (numero == 9)
					{
						romano = "IX";
					}
					else if (numero == 10)
					{
						romano = "X";
					}
					lblromano.Text = "El numero equivale a" +" " + romano + "" + " "+ "en romano";
			     }
				else
				{
					textNumero.Focus();
					textNumero.SelectAll();
					lblromano.Text = "Ingrese un numero del 1 al 10";
				}
			}
			catch (Exception)
			{
				textNumero.Focus();
				textNumero.SelectAll();
				lblromano.Text = "Ingrese solo numero";
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
