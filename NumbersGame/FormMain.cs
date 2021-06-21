using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class FormMain : Form
    {

        NumbersGame game = new NumbersGame();

        Timer timer = new Timer();

        FormAbout formAbout;
        FormLose formLose = new FormLose();
        FormWin formWin = new FormWin();

        int gameStatus;

        public FormMain() {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            tsslTimePlayed.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tsmiAbout(object sender, EventArgs e) {
            formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e) {

            game = new NumbersGame();

            gameStatus = 0;

            FormNewGame newGameGoal = new FormNewGame();
            newGameGoal.lblGameGoal.Text = $"You must get number {game.targetNumber} with {game.MinStepsRequired} operations only!";
            newGameGoal.ShowDialog();

            ButtonsEnadled(true);
            game.StatusChanged += UpdateForm;
            UpdateForm();

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void UpdateForm() {
            lblPlayerNumber.Text = game.PlayerNumber.ToString();
            lblTargetNumber.Text = game.targetNumber.ToString();
            lblCommands.Text = "Commands: " + game.Commands.ToString();
            lblSteps.Text = "Steps: " + game.Steps.ToString();

            game.PlayerWon(out gameStatus);

            if (gameStatus == 1) {
                formWin.ShowDialog();
                ButtonsEnadled(false);
            } else if (gameStatus == -1) {
                formLose.ShowDialog();
                ButtonsEnadled(false);
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            if (game != null) {
                game.Reset();
            }
        }

        private void btnPlusOne_Click(object sender, EventArgs e) {
            if (game != null) {
                game.AddOne();
            }
        }

        private void btnMultiplyByTwo_Click(object sender, EventArgs e) {
            if (game != null) {
                game.MultiplyByTwo();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            if (game != null) {
                game.StepBack();
            }
        }

        private void ButtonsEnadled(bool OnOff) {
            btnAddOne.Enabled = OnOff;
            btnMultiplyByTwo.Enabled = OnOff;
            btnBack.Enabled = OnOff;
            btnReset.Enabled = OnOff;
        }

        private void tsmiRules_Click(object sender, EventArgs e) {

        }
    }
}
