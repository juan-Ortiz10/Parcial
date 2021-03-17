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
    public partial class invertir_palabra : Form
    {
        public invertir_palabra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pnormal;
            string pinvert = "";
            pnormal = textBox1.Text;

            for (int x = pnormal.Length-1; x>=0; x--)
            {
                pinvert += pnormal[x];
            }
            MessageBox.Show("La palabra invertida es: " + pinvert, "Palabra invertida");
            textBox1.Clear();
        }

        private void invertir_palabra_Load(object sender, EventArgs e)
        {

        }
    }
}
