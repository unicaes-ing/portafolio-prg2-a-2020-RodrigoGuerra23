using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private static int FuncionFibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return FuncionFibonacci(n - 1) + FuncionFibonacci(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtFibona.Text = FuncionFibonacci(Convert.ToInt32(txtNumero.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
