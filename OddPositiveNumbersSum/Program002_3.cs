/*******************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 3.
 * С клавиатуры вводятся числа, пока не будет введен 0.
 * Подсчитать сумму всех нечетных положительных чисел.
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPositiveNumbersSum
{
    class Program002_3
    {
        static void Main(string[] args) {

            Console.Write("Start entering integer numbers.\nTo finish enter ZERO:\n");

            string numberStr;
            int numberInt;
            int sum = 0;
            int count = 0;

            do {
                Console.Write($"{++count}: ");
                numberStr = Console.ReadLine();
                numberInt = Convert.ToInt32(numberStr);

                if ((numberInt % 2 != 0) && (numberInt > 0)) {
                    sum += numberInt;
                }

            } while (numberStr != "0");

            Console.WriteLine($"The sum of all odd positive numbers among entered {count} is {sum}.");

        }
    }
}
