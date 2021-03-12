using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class PAN : Form
    {
        public PAN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEnunciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            if (txtEnunciado.Text == "" || txtEnunciado.Text == " ")
            {
                MessageBox.Show("Datos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cadena = txtEnunciado.Text;
                try
                {
                    string z = cadena.ToLower();
                    if (comprobar(z))
                    {
                        MessageBox.Show("Es un Pangrama", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No es un Pangrama", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool comprobar(string txt)
        {
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            foreach (char c in abc)
            {
                if (!txt.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void PAN_Load(object sender, EventArgs e)
        {

        }
    }
}
