using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public delegate void PassValueHandler(string value);

    public partial class FormGuess : Form
    {
        public event PassValueHandler PassValue;

        public FormGuess() {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e) {
            if (PassValue != null) {
                PassValue(tbPlayerNumber.Text);
            }
            this.Close();
        }
    }
}
