﻿using System;
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
    }
}
