using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson004_Homework
{
    class Program
    {
        static void Main(string[] args) {
            #region Task1
            void Task1() {
                Console.Clear();
                Console.WriteLine("Task1");
                Console.WriteLine(
                    "Дан целочисленный массив из 20 элементов.\n" +
                    "Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.\n" +
                    "Заполнить случайными числами.\n" +
                    "Написать программу, позволяющую найти и вывести количество пар элементов массива,\n" +
                    "в которых только одно число делится на 3.\n" +
                    "В данной задаче под парой подразумевается два подряд идущих элемента массива.\n" +
                    "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ 2.\n"
                );

                int arrDimension = 20;
                int[] arr = new int[arrDimension];
                int arrMinValue = -10_000;
                int arrMaxValue = 10_000;
                int count = 0;
                Random rnd = new Random();

                Console.Write("Array: ");

                for (int i = 0; i < arr.Length - 1; i++) {
                    arr[i] = rnd.Next(arrMinValue, arrMaxValue);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < arr.Length - 1; i++) {
                    Console.Write($"{arr[i]} % 3 = {arr[i] % 3}\tand\t{arr[i + 1]} % 3 = {arr[i + 1] % 3}");
                    if ((arr[i] % 3 == 0) ^ (arr[i + 1] % 3 == 0)) {
                        Console.WriteLine("\t<-- Only one number is divisible by 3 without remainder");
                        count++;
                    } else {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine($"\nAmount of pairs where only one number is divided by 3 with no remainder is {count}.\n");
                Console.Write("Press any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task2
            #endregion

            #region Task3
            #endregion

            #region Task4
            #endregion

            #region Task5
            #endregion


            bool flag = false;

            ConsoleKeyInfo choice;

            Console.OutputEncoding = Encoding.Unicode;

            do {
                Console.Clear();
                Console.WriteLine(
                    "\n\n" +
                    "=======================================\n" +
                    "Lesson 4: Homework\n" +
                    "=======================================\n" +
                    "1. Pairs of Numbers in Array\n" +
                    "2. Pairs of Numbers in Array with StaticClass\n" +
                    "3. 1D Arrays\n" +
                    "4. Authentification with Files\n" +
                    "5. 2D Array Library\n" +
                    "0. Exit\n" +
                    "======================================="
                );

                Console.Write("Enter your choice: ");

                choice = Console.ReadKey(false);

                switch (choice.Key) {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Task1();
                        break;
                    //case ConsoleKey.D2:
                    //case ConsoleKey.NumPad2:
                    //    Task2();
                    //    break;
                    //case ConsoleKey.D3:
                    //case ConsoleKey.NumPad3:
                    //    Task3();
                    //    break;
                    //case ConsoleKey.D4:
                    //case ConsoleKey.NumPad4:
                    //    Task4();
                    //    break;
                    //case ConsoleKey.D5:
                    //case ConsoleKey.NumPad5:
                    //    Task5();
                    //    break;
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        flag = true;
                        break;
                    default:
                        break;
                }
            } while (!flag);
        }
    }
}
