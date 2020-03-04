using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class ejercicio5 : Form
    {
        public ejercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNombre.Text;
                double total = 0, subtotal = 0, imp = 0, horas = Convert.ToDouble(txtTrabajadas.Text), canthr = Convert.ToDouble(txthora.Text), t = 0;
                subtotal = horas * canthr;
                imp = subtotal * 0.10;
                total = subtotal - imp;
                dataGridView.Rows.Add(name, horas, String.Format("{0:C2}", canthr), String.Format("{0:C2}", subtotal), String.Format("{0:C2}", imp), String.Format("{0}", total));
                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    t += Convert.ToDouble(dataGridView.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = String.Format("{0:C2}", t);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correctamente por favor");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
