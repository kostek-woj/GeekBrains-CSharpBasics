using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2DLib
{
    public class Array2d
    {
        private int[,] _arr;

        public Array2d() {

        }
        public Array2d(int dimension, int val) {
            _arr = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++) {
                for (int j = 0; j < dimension; j++) {
                    _arr[i, j] = val;
                }
            }
        }

        public Array2d(int dimension, int min, int max) {
            _arr = new int[dimension, dimension];
            Random rnd = new Random();
            for (int i = 0; i < dimension; i++) {
                for (int j = 0; j < dimension; j++) {
                    _arr[i, j] = rnd.Next(min, max);
                }
            }
        }

        public Array2d(string fileName) {

            string fullFileName = @"../../" + fileName;
            string[] arrFromFile = { };

            try {
                arrFromFile = File.ReadAllLines(fullFileName);
            } catch (FileNotFoundException e) {
                Console.WriteLine($"\nFile {fileName} is not found:\n{e.Message}");
            } catch (IOException e) {
                Console.WriteLine($"\nSomething went wrong:\n{e.Message}");
            }

            _arr = new int[arrFromFile.Length, arrFromFile.Length];

            for (int i = 0; i < arrFromFile.Length; i++) {
                string[] row = arrFromFile[i].Split(' ');
                for (int j = 0; j < arrFromFile.Length; j++) {
                    _arr[i, j] = Convert.ToInt32(row[j]);
                }
            }
        }

        public int Min {
            get {
                int min = _arr[0, 0];
                for (int i = 0; i < _arr.GetLength(0); i++) {
                    for (int j = 0; j < _arr.GetLength(1); j++) {
                        if (_arr[i, j] < min) {
                            min = _arr[i, j];
                        }
                    }
                }
                return min;
            }
        }

        public int Max {
            get {
                int max = _arr[0, 0];
                for (int i = 0; i < _arr.GetLength(0); i++) {
                    for (int j = 0; j < _arr.GetLength(1); j++) {
                        if (_arr[i, j] > max) {
                            max = _arr[i, j];
                        }
                    }
                }
                return max;
            }
        }
        
        public int CountPositive {
            get {
                int count = 0;
                for (int i = 0; i < _arr.GetLength(0); i++) {
                    for (int j = 0; j < _arr.GetLength(1); j++) {
                        if (_arr[i, j] > 0) {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
        
        public double Average {
            get {
                double sum = 0;
                for (int i = 0; i < _arr.GetLength(0); i++) {
                    for (int j = 0; j < _arr.GetLength(1); j++) {
                        sum += _arr[i, j];
                    }
                }
                return sum / (_arr.GetLength(0) * _arr.GetLength(1));
            }
        }

        public int Sum() {
            int sum = 0;
            for (int i = 0; i < _arr.GetLength(0); i++) {
                for (int j = 0; j < _arr.GetLength(1); j++) {
                    sum += _arr[i, j];
                }
            }
            return sum;
        }

        public int SumOfGreaterThan(int number) {
            int sum = 0;
            for (int i = 0; i < _arr.GetLength(0); i++) {
                for (int j = 0; j < _arr.GetLength(1); j++) {
                    if (_arr[i, j] > number) {
                        sum += _arr[i, j];
                    }
                }
            }
            return sum;
        }

        public void IndexOfBiggestElement(out int[] index) {
            index = new int[] { -1, -1 };
            int max = this._arr[0, 0];
            for (int i = 0; i < this._arr.GetLength(0); i++) {
                for (int j = 0; j < this._arr.GetLength(1); j++) {
                    if (this._arr[i, j] > max) {
                        max = this._arr[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
        }

        public void readFromFile(string fileName) {
            string fullFileName = @"../../" + fileName;
            string[] arrFromFile = { };

            try {
                arrFromFile = File.ReadAllLines(fullFileName);
            } catch (FileNotFoundException e) {
                Console.WriteLine($"\nFile {fileName} is not found:\n{e.Message}");
            } catch (IOException e) {
                Console.WriteLine($"\nSomething went wrong:\n{e.Message}");
            }

            _arr = new int[arrFromFile.Length, arrFromFile.Length];

            for (int i = 0; i < arrFromFile.Length; i++) {
                string[] row = arrFromFile[i].Split(' ');
                for (int j = 0; j < arrFromFile.Length; j++) {
                    _arr[i, j] = Convert.ToInt32(row[j]);
                }
            }
        }

        public void writeToFile(string fileName) {
            string fullFileName = @"../../" + fileName;
            try {
                StreamWriter sw = new StreamWriter(fullFileName);
                for (int i = 0; i < _arr.GetLength(0); i++) {
                    for (int j = 0; j < _arr.GetLength(1); j++) {
                        sw.Write(_arr[i, j] + 
                            ((j < _arr.GetLength(1) - 1) ? " " : ""));
                    }
                    sw.WriteLine();
                }
                sw.Close();
            } catch (IOException e) {
                Console.WriteLine($"\nSomething went wrong:\n{e.Message}");
            }
        }

        public override string ToString() {
            string s = "";
            for (int i = 0; i < _arr.GetLength(0); i++) {
                for (int j = 0; j < _arr.GetLength(1); j++) {
                    s += _arr[i, j] + "\t";
                }
                s += "\n";
            }
            return s;
        }
    }
}
