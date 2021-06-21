using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class FormGame : Form
    {
        GuessingGame game = new GuessingGame();

        public FormGame() {
            InitializeComponent();
            lblGuessNumber.Text = $"Guess the number from {game.MinNumber} to {game.MaxNumber} !";
        }

        public void formGuess_PassValue(string value) {
            lblResult.Text = game.Check(value);
        }

        private void btnGuess_Click(object sender, EventArgs e) {
            FormGuess formGuess = new FormGuess();
            formGuess.PassValue += new PassValueHandler(formGuess_PassValue);
            formGuess.Show();
        }
    }
}
