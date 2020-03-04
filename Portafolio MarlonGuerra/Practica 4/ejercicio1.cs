﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
	public partial class ejercicio1 : Form
	{
		public ejercicio1()
		{
			InitializeComponent();
		}

		public static double suma (double n1, double n2, double n3, double n4)
		{
			return n1 + n2 + n3 + n4;
		}

		private void btnSumar_Click(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(txtNum1.Text);
				double num2 = Convert.ToDouble(txtNum2.Text);
				double num3 = Convert.ToDouble(txtNum3.Text);
				double num4 = Convert.ToDouble(txtNum4.Text);
				lblSuma.Text = "La suma es :" + suma(num1, num2, num3, num4).ToString();
				txtNum1.Clear();
				txtNum2.Clear();
				txtNum3.Clear();
				txtNum4.Clear();
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese los 4 numeros");
			}


		}
	}
}