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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMod1_Click(object sender, EventArgs e)
        {
            MDN mdn = new MDN();
            this.Hide();
            mdn.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CL cl = new CL();
            this.Hide();
            cl.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PAN pan = new PAN();
            this.Hide();
            pan.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            area_Cuadrado go = new area_Cuadrado();
            this.Hide();
            go.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            invertir_palabra go = new invertir_palabra();
            this.Hide();
            go.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suma_dificil go = new suma_dificil();
            this.Hide();
            go.ShowDialog();
            this.Show();
        }
    }
}
