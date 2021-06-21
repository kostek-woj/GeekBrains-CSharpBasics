using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UpsAndDowns
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
