using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Inversiones : Form
    {
        public Inversiones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double toInver = Convert.ToDouble(textInversionista1.Text) + Convert.ToDouble(textInversionista2.Text) + Convert.ToDouble(textInversionista3.Text);
            textPorcentaje1.Text = Convert.ToString(((Convert.ToDouble(textInversionista1.Text) / toInver) * 100).ToString("N2")) + "%";
            textPorcentaje2.Text = Convert.ToString(((Convert.ToDouble(textInversionista2.Text) / toInver) * 100).ToString("N2")) + "%";
            textPorcentaje3.Text = Convert.ToString(((Convert.ToDouble(textInversionista3.Text) / toInver) * 100).ToString("N2")) + "%";
            textTotal.Text = toInver.ToString("C2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textInversionista1.Clear();
            textInversionista2.Clear();
            textInversionista3.Clear();
            textPorcentaje1.Clear();
            textPorcentaje2.Clear();
            textPorcentaje3.Clear();
            textTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
