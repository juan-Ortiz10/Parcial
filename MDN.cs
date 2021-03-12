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
    public partial class MDN : Form
    {
        public MDN()
        {
            InitializeComponent();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum1.Text == " " || txtNum2.Text == "" || txtNum2.Text == " ")
            {
                MessageBox.Show("Datos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int n1 = Int32.Parse(txtNum1.Text);
                    int n2 = Int32.Parse(txtNum2.Text);
                    if (n1 > n2)
                    {
                        MessageBox.Show(n1 + " es mayor que " + n2, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(n2 + " es mayor que " + n1, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }   

        private void MDN_Load(object sender, EventArgs e)
        {

        }
    }
}
