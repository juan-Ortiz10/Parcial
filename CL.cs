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
    public partial class CL : Form
    {
        public CL()
        {
            InitializeComponent();
        }
        private void btnCont_Click(object sender, EventArgs e)
        {
            if (txtPalabra.Text == "" || txtPalabra.Text == " " || txtLetra.Text == "" || txtLetra.Text == " ")
            {
                MessageBox.Show("Datos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtLetra.Text.Length > 1 || txtLetra.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir 1 letra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string p = txtPalabra.Text;
                    string a = p.ToLower();
                    string w = txtLetra.Text;
                    string y = w.ToLower();
                    char l = Convert.ToChar(y);
                    int aux = 0;
                    foreach (char x in a)
                    {
                        if (x == l)
                        {
                            aux++;
                        }
                    }
                    MessageBox.Show("La letra " + w + " se repite " + aux + " veces", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception v)
                {
                    MessageBox.Show(v.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CL_Load(object sender, EventArgs e)
        {

        }
    }
}
