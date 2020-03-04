﻿using System;
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

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(txtAgregar.Text);
				listBox1.Items.Add(num);
				txtAgregar.Clear();
				txtBuscar.Clear();
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese un numero");
				txtAgregar.SelectAll();
				txtAgregar.Focus();
			}
		}
		public static int Buscar(int nBuscar, ListBox Lista)
		{
			int cont = 0;
			foreach (int n in Lista.Items)
			{
				if (n == nBuscar) cont++;
			}
			return cont;

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(txtBuscar.Text);
				int cant = Buscar(num, listBox1);
				MessageBox.Show("Se encuentra" + cant + " de vecces");
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese solo numero");
				txtBuscar.SelectAll();
				txtBuscar.Focus();
			}
		}

	}
}
