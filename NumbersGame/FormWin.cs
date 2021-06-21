using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class FormWin : Form
    {
        public FormWin() {
            InitializeComponent();
        }

        private void btnLoseOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
