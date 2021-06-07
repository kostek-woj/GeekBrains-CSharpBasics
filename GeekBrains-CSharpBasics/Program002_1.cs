/***********************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 1.
 * Написать метод, возвращающий минимальное из трёх чисел.
 ***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_CSharpBasics
{
    class Program002_1
    {
        static int SmallestNumber(int a, int b) {
            return a < b ? a : b;
        }

        static int SmallestNumber(int a, int b, int c) {
            int x = SmallestNumber(a, b);
            return x < c ? x : c;
        }

        static void Main(string[] args) {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Enter an integer number A: ");
            string userInputA = Console.ReadLine();

            Console.Write("Enter an integer number B: ");
            string userInputB = Console.ReadLine();

            Console.Write("Enter an integer number C: ");
            string userInputC = Console.ReadLine();

            int numberA = Convert.ToInt32(userInputA);
            int numberB = Convert.ToInt32(userInputB);
            int numberC = Convert.ToInt32(userInputC);

            Console.WriteLine($"The smallest number out of {numberA}, {numberB} and {numberC} is {SmallestNumber(numberA, numberB, numberC)}");

        }
    }
}
