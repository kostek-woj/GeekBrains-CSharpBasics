using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class GuessingGame
    {
        private int _number;
        private int _steps;
        private int _min;
        private int _max;

        public int Number { get { return _number; } }
        public int Steps { get { return _steps; } }

        public int MinNumber { get { return _min; } }
        public int MaxNumber { get { return _max; } }

        public GuessingGame() {
            this._min = 1;
            this._max = 100;
            Random rnd = new Random();
            this._number = rnd.Next(_min, _max + 1);
            this._steps = 0;
        }

        public string Check(string playerInput) {
            try {
                int playerNumber = Convert.ToInt32(playerInput);
                string result = "";

                if (playerNumber < this.Number) {
                    result = "Your number is too small.";
                    this._steps++;
                } else if (playerNumber > this.Number) {
                    result = "Your number is too big.";
                    this._steps++;
                } else {
                    result = $"You have won in {this.Steps} tries!";
                }

                return result;

            } catch (Exception ex) {
                Console.WriteLine("Error occured!\n" + ex.Message);
                return null;
            }
        }
    }
}
