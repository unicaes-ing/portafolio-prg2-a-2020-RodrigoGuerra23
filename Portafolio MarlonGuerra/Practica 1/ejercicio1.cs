using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, prom;
            a = Convert.ToDouble(txtExamen1p.Text);
            b = Convert.ToDouble(txtExamen2p.Text);
            c = Convert.ToDouble(txtExamen3p.Text);
            prom = (a + b + c) / 3;
            textPromedio.Text = Convert.ToString(prom);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1p.Clear();
            txtExamen2p.Clear();
            txtExamen3p.Clear();
            textPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
