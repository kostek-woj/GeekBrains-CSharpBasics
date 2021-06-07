/******************************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 7.
 * 
 * A) Разработать рекурсивный метод, который выводит на экран
 * числа от a до b (a<b).
 * 
 * B) *Разработать рекурсивный метод, который считает
 * сумму чисел от a до b.
 ******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAB
{
    class Program002_7
    {
        static void Main(string[] args) {

            Console.WriteLine("This program prints all numbers in range from integer number A to integer number B (A < B).");
            Console.Write("Enter integer number A: ");
            string numberAStr = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAStr);

            Console.Write("Enter integer number B: ");
            string numberBStr = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBStr);

            Console.WriteLine($"All numbers from {numberA} to {numberB}:");
            writeNumber(numberA, numberB);

            Console.WriteLine();

            Console.WriteLine($"The sum of all numbers from {numberA} to {numberB} is {sumRange(numberA, numberB)}.");

        }


        // A
        static void writeNumber(int a, int b) {
            Console.Write($"{a} ");
            if (a < b) {
                writeNumber(++a, b);
            }

        }


        // B
        static int sumRange(int a, int b) {
            if (a == b) {
                return b;
            } else {
                return a + sumRange(++a, b);
            }
        }
    }
}
