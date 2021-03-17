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
    public partial class suma_dificil : Form
    {
        public suma_dificil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            while(texto.Contains("  "))
            {
                texto = texto.Replace("  ", " ");
            }
            string[] partes = texto.Split();
            double suma = 0;
            foreach (string parte in partes)
            {
                suma += double.Parse(parte.Trim());
            }
            textBox1.Text = suma.ToString();
        }
    }
}
