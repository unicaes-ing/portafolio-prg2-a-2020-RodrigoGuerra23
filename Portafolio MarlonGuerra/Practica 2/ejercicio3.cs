using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    double tot, cant = Convert.ToDouble(txtlco.Text);
                    if (lstde.Text == "Pulgadas" && lsta.Text == "Pies")
                    {
                        tot = cant * 1 / 12;
                    }
                    else if (lstde.Text == "Pulgadas" && lsta.Text == "Yardas")
                    {
                        tot = cant * 1 / 36;
                    }
                    else if (lstde.Text == "Pies" && lsta.Text == "Pulgadas")
                    {
                        tot = cant * 12;
                    }
                    else if (lstde.Text == "Pies" && lsta.Text == "Yardas")
                    {
                        tot = cant * 1 / 3;
                    }
                    else if (lstde.Text == "Yardas" && lsta.Text == "Pulgadas")
                    {
                        tot = cant * 36;
                    }
                    else if (lstde.Text == "Yardas" && lsta.Text == "Pies")
                    {
                        tot = cant * 3;
                    }
                    else
                    {
                        tot = cant;
                    }
                    txtconv.Text = Convert.ToString(tot);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
