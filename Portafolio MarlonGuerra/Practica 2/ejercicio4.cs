using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ejercicio4
{
    public partial class ejercicio4 : Form
    {
        public ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validado = true;
            error.Clear();
            if (txtCorreo.TextLength <= 0)
            {
                error.SetError(txtCorreo, "Ingrese su correo");
                validado = false;
            }
            else
            {
                string patronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    error.SetError(txtCorreo, "Ingrese correctamente su correo");
                    validado = false;
                }
            }
            if (txtContras.TextLength <= 0)
            {
                error.SetError(txtContras, "Ingrese la contraseña");
                validado = false;
            }
            else
            {
                string patronContra = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
                if (!Regex.IsMatch(txtContras.Text, patronContra))
                {
                    error.SetError(txtContras, "Formato de contraseña no valido");
                    validado = false;
                }
            }
            if (!Equals(txtContras.Text, txtConfirContras.Text) || txtConfirContras.TextLength <= 0)
            {
                error.SetError(txtConfirContras, "La contraseña no es igual");
                validado = false;
            }
            if (validado)
            {
                MessageBox.Show("Los Datos fueron validados correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
