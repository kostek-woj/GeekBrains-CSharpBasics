/******************************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 6.
 * 
 * *Написать программу подсчета количества «хороших» чисел
 * в диапазоне от 1 до 1 000 000 000.
 *  
 * «Хорошим» называется число, которое делится на сумму своих цифр.
 *  
 * Реализовать подсчёт времени выполнения программы,
 * используя структуру DateTime.
 ******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program002_6
    {
        static void Main(string[] args) {

            long count = 0;
            
            Console.WriteLine("Program writes and counts all numbers from 1 to 1,000,000,000\n"
                + "which is divisible by the sum of their digits.");
            Console.WriteLine("Program has started...");

            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1_000_000_000; i++) {
                if (isGood(i)) {
                    Console.Write($"{i} ");
                    count++;
                }
            }

            Console.WriteLine($"There are {count} numbers, divisible by the sum of their digits.\n" +
                $"It took {DateTime.Now - start} to count them.");
        }

        static int numberDigitsSum(int num) {
            if (num / 10 > 0) {
                return num % 10 + numberDigitsSum(num / 10);
            } else {
                return num;
            }

        }

        static bool isGood(int num) {
            return ((double)num / (double)numberDigitsSum(num)) % 1 == 0 ? true : false;
        }
    }
}
