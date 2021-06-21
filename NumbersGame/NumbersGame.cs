using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersGame
{
    class NumbersGame
    {
        private int _playerNumber;
        private int _steps = 0;
        private int _commands = 0;

        public int targetNumber { get; private set; }
        
        Stack<int> history = new Stack<int>();

        public event Action StatusChanged;

        public int PlayerNumber {
            get { return _playerNumber;  }
        }

        public int Steps {
            get { return _steps; }
        }

        public int MinStepsRequired {
            get {
                int f = targetNumber;
                int i = 0;
                while (f != 1) {
                    f = (f % 2 == 0 ? f / 2 : f - 1);
                    i++;
                }
                return i;
            }
        }

        public int Commands {
            get {
                return _commands;
            }
        }

        public NumbersGame() {
            targetNumber = new Random().Next(10, 101);
            _playerNumber = 1;
            StatusChanged?.Invoke();
        }

        public NumbersGame(int targetNumber) {
            this.targetNumber = targetNumber;
            _playerNumber = 1;
            StatusChanged?.Invoke();
        }

        public NumbersGame(int min, int max) {
            targetNumber = new Random().Next(min, max + 1);
            _playerNumber = 1;
            StatusChanged?.Invoke();
        }

        public int AddOne() {
            history.Push(_playerNumber);
            _playerNumber++;
            _steps++;
            _commands++;
            StatusChanged?.Invoke();
            return _playerNumber;
        }

        public int MultiplyByTwo() {
            history.Push(_playerNumber);
            _playerNumber *= 2;
            _steps++;
            _commands++;
            StatusChanged?.Invoke();
            return _playerNumber;
        }

        public void Reset() {
            _playerNumber = 1;
            history.Clear();
            _steps = 0;
            _commands = 0;
            StatusChanged?.Invoke();
        }

        public void StepBack() {
            _steps--;
            _commands++;
            if (history.Count != 0) {
                _playerNumber = history.Pop();
            } else {
                _playerNumber = 1;
            }
            StatusChanged?.Invoke();
        }

        public void PlayerWon(out int gameStatus) {
            gameStatus = 0;
            if (this.Steps == this.MinStepsRequired && this.PlayerNumber == this.targetNumber) {
                gameStatus = 1;
            } else if (this.Steps > this.MinStepsRequired || this.PlayerNumber > this.targetNumber) {
                gameStatus = -1;
            }
        }

        public override string ToString() {
            return _playerNumber.ToString();
        }
    }
}
