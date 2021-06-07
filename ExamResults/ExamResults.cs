using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResultsLib
{
    public class ExamResults
    {
        private int _studentsAmount = 0;
        private double _lowestMedian = Double.MaxValue;
        private Dictionary<string, double> _students = new Dictionary<string, double>();

        public ExamResults(string fileName) {
            
            string fullFileName = @"../../" + fileName;
            string[] recordsFromFile = { };

            try {
                recordsFromFile = File.ReadAllLines(fullFileName);
            } catch (FileNotFoundException e) {
                Console.WriteLine($"\nFile {fileName} is not found:\n{e.Message}");
            } catch (IOException e) {
                Console.WriteLine($"\nSomething went wrong:\n{e.Message}");
            }

            _studentsAmount = Convert.ToInt32(recordsFromFile[0]);

            for (int i = 1; i < recordsFromFile.Length; i++) {
                
                string[] row = recordsFromFile[i].Split(' ');
                string name = row[0] + " " + row[1];
                double median = 0.0d;
                
                // computing median mark for current student
                for (int k = 2; k < row.Length; k++) {
                    median += Convert.ToDouble(row[k]);
                }
                
                median /= (row.Length - 2);

                if (!_students.ContainsKey(name)) {
                    _students.Add(name, median);
                }

                if (median < _lowestMedian) {
                    _lowestMedian = median;
                }
                
            }

        }


        public void PrintThreeWorstAndOthersWithTheSameMedianMark() {
            
            int i = 0;

            Console.WriteLine($"Students with the lowest median mark of {_lowestMedian}:");
            
            foreach (KeyValuePair<string, double> kvp in _students.OrderBy(key => key.Value).ThenBy(name => name.Key)) {
                if (i++ == 3) {
                    Console.WriteLine(
                        "\n=====================================================================\n" +
                         $"And other students with the same median mark of {_lowestMedian}" +
                        "\n=====================================================================\n"
                    );
                }
                if (kvp.Value == _lowestMedian) {
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
            }
        }
    }
}
