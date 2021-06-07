using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThree
{
    class Program
    {
        static int SmallestOfThree(int a, int b, int c) {
            int smallest = a;
            if (b < a) {
                smallest = b;
            } else if (c < a) {
                smallest = c;
            }
            return smallest;
        }

        static void Main(string[] args) {
            
            Console.Write("Enter 3 integer numbers separated by SPACE: ");
            string numbersStr = Console.ReadLine();
            
            int[] numbersArr = new int[3];
            for (int i = 0; i < numbersStr.Split(' ').Length; i++) {
                numbersArr[i] = Convert.ToInt32(numbersStr.Split(' ')[i]);
            }

            Console.WriteLine($"The smallest number of {numbersArr[0]}, {numbersArr[1]} and {numbersArr[2]}" +
                $" is {SmallestOfThree(numbersArr[0], numbersArr[1], numbersArr[2])}.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
