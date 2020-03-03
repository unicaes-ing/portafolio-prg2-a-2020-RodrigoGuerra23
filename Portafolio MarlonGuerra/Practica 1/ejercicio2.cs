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

        private void Calcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDecimal.Text);
            string bin = "";
            while (a > 0)
            {
                bin = a % 2 + bin;
                a = a / 2;
            }
            txtBinario.Text = bin;
            int b = int.Parse(txtDecimal.Text);
            string octa = "";
            double resi = 0;
            do
            {
                resi = ((double)(b)) / 8;
                b = b / 8;
                resi = (resi - b) * 8;
                octa = resi + octa;
            } while (b != 0);
            txtOctal.Text = octa;
            int c = int.Parse(txtDecimal.Text);
            string hexa = "";
            double residuo = 0;
            do
            {
                residuo = ((double)(c)) / 16;
                c = c / 16;
                residuo = (residuo - c) * 16;
                if (residuo == 10)
                    hexa = "A" + hexa;
                else if (residuo == 11)
                    hexa = "B" + hexa;
                else if (residuo == 12)
                    hexa = "C" + hexa;
                else if (residuo == 13)
                    hexa = "D" + hexa;
                else if (residuo == 14)
                    hexa = "E" + hexa;
                else if (residuo == 15)
                    hexa = "F" + hexa;
                else
                    hexa = residuo + hexa;
            } while (c != 0);
            txtHexadecimal.Text = hexa;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Clear();
            txtBinario.Clear();
            txtHexadecimal.Clear();
            txtOctal.Clear();
        }
    
    }
}
