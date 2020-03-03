using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0, cant = 0, desc = 0, descu = 0;
                if (radio1.Checked)
                {
                    descu = 0;
                }
                else if (radio2.Checked)
                {
                    descu = 0.05;
                }
                else if (radio3.Checked)
                {
                    descu = 0.10;
                }
                else if (radio4.Checked)
                {
                    descu = 0.15;
                }
                else if (radio5.Checked)
                {
                    descu = 0.20;
                }
                precio = Convert.ToDouble(txtPrec.Text);
                cant = Convert.ToDouble(txtCant.Text);
                desc = (precio * cant) * desc;
                txtDesc.Text = String.Format("{0:C2}", descu);
                txtTotal.Text = String.Format("{0:C2}", (precio * cant) - descu);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese correctamente los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtDesc.Clear();
            txtPrec.Clear();
            txtTotal.Clear();
            txtCant.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
