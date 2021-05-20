/***********************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 2.
 * Написать метод подсчета количества цифр числа.
 ***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDigits
{
    class Program002_2
    {
        static void Main(string[] args) {
            
            Console.Write("Enter an integer: ");
            
            string numberStr = Console.ReadLine();
            int numberInt = Convert.ToInt32(numberStr);
            int digits = 0;

            while (numberInt > 0) {
                numberInt /= 10;
                digits++;
            }

            Console.WriteLine($"There are {digits} digit" + (digits > 1 ? "s" : "") + $" in {Convert.ToInt32(numberStr)}");
        }
    }
}
