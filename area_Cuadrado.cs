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
    public partial class area_Cuadrado : Form
    {
        public area_Cuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado, altura;
            lado = int.Parse(textBox1.Text);
            altura = int.Parse(textBox2.Text);
            int area = lado * altura;

            MessageBox.Show("el area del cuadrado es: "+area, "Resultado");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
