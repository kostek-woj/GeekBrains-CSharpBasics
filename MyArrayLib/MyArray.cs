using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayLib
{
    public class MyArray
    {
        private int[] _arr;

        public MyArray(int n, int el) {
            _arr = new int[n];
            for (int i = 0; i < n; i++) {
                _arr[i] = el;
            }
        }

        // The same signature
        // =========================================
        //public MyArray(int n, int min, int max) {
        //    _arr = new int[n];
        //    Random rnd = new Random();
        //    for (int i = 0; i < n; i++) {
        //        _arr[i] = rnd.Next(min, max);
        //    }
        //}

        public MyArray(int n, int startingValue, int step) {
            _arr = new int[n];
            _arr[0] = startingValue;
            for (int i = 1; i < n; i++) {
                _arr[i] = _arr[i - 1] + step;
            }
        }

        public void PopulateWithRandomNumbers(int min, int max) {
            int dimension = _arr.GetLength(0);
            Random rnd = new Random();
            for (int i = 0; i < dimension; i++) {
                _arr[i] = rnd.Next(min, max);
            }
        }

        public int[] Inverse() {
            int[] arrNew = (int[])_arr.Clone();
            for (int i = 0; i < _arr.Length; i++) {
                arrNew[i] = -arrNew[i];
            }
            return arrNew;
        }

        public MyArray Multi(int n) {
            for (int i = 0; i < _arr.Length; i++) {
                _arr[i] *= n;
            }
            return this;
        }

        public int MaxCount() {
            int count = 0;
            for (int i = 0; i < _arr.Length; i++) {
                if (_arr[i] == this.MaxValue) {
                    count++;
                }
            }
            return count;
        }

        public int MaxValue {
            get {
                int max = int.MinValue;
                for (int i = 0; i < _arr.Length; i++) {
                    if (_arr[i] > max) {
                        max = _arr[i];
                    }
                }
                return max;
            }
        }

        public int this[int i] {
            get {
                return _arr[i];
            }
            set {
                _arr[i] = value;
            }
        }

        public int Max {
            get {
                int max = _arr[0];
                for (int i = 1; i < _arr.Length; i++) {
                    if (_arr[i] > max) {
                        max = _arr[i];
                    }
                }
                return max;
            }
        }

        public int Min {
            get {
                int min = _arr[0];
                for (int i = 1; i < _arr.Length; i++) {
                    if (_arr[i] < min) {
                        min = _arr[i];
                    }
                }
                return min;
            }
        }

        public int CountPositive {
            get {
                int count = 0;
                for (int i = 0; i < _arr.Length; i++) {
                    if (_arr[i] > 0) {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Sum {
            get {
                int sum = 0;
                foreach (int el in _arr) {
                    sum += el;
                }
                return sum;
            }
        }

        public override string ToString() {
            string arrStr = "";
            foreach (int value in _arr) {
                arrStr += value + " ";
            }
            return arrStr.Trim();
        }
    }
}
