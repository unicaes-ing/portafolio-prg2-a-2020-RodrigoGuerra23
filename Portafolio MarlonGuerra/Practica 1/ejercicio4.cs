using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLibro.SelectedItem.Equals("La Divina Comedia"))
            {
                txtprecio.Text = "15.00";
            }
            else if (comboBoxLibro.SelectedItem.Equals("Jupiter"))
            {
                txtprecio.Text = "20.50";
            }
            else if (comboBoxLibro.SelectedItem.Equals("Narraciones Extraordinarias"))
            {
                txtprecio.Text = "10.50";
            }
            else if (comboBoxLibro.SelectedItem.Equals("Luz Negra"))
            {
                txtprecio.Text = "8.00";
            }
            else if (comboBoxLibro.SelectedItem.Equals("20 poemas de amor y una canción desesperada"))
            {
                txtprecio.Text = "5.00";
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double subt, imp, tot;
            if (comboBoxLibro.SelectedItem.Equals("La Divina Comedia"))
            {
                subt = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtsubtotal.Text = subt.ToString("{0:C2}");
                txtimpuesto.Text = imp.ToString("{0:C2}");
                txttotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBoxLibro.SelectedItem.Equals("Jupiter"))
            {
                subt = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtsubtotal.Text = subt.ToString("{0:C2}");
                txtimpuesto.Text = imp.ToString("{0:C2}");
                txttotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBoxLibro.SelectedItem.Equals("Narraciones Extraordinarias"))
            {
                subt = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtsubtotal.Text = subt.ToString("0:C2");
                txtimpuesto.Text = imp.ToString("{0:C2}");
                txttotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBoxLibro.SelectedItem.Equals("Luz Negra"))
            {
                subt = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtsubtotal.Text = subt.ToString("{0:C2}");
                txtimpuesto.Text = imp.ToString("{0:C2}");
                txttotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBoxLibro.SelectedItem.Equals("20 poemas de amor y una canción desesperada"))
            {
                subt = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtsubtotal.Text = subt.ToString("0:C2");
                txtimpuesto.Text = imp.ToString("{0:C2}");
                txttotal.Text = tot.ToString("{0:C2}");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtsubtotal.Clear();
            txtprecio.Clear();
            txtimpuesto.Clear();
            txtcantidad.Clear();
            comboBoxLibro.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
