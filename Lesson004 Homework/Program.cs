using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayLib;
using Array2DLib;

namespace Lesson004_Homework
{
    public static class ArrayPairs
    {
        public static int CountPairs(int[] arr) {

            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++) {
                if ((arr[i] % 3 == 0) ^ (arr[i + 1] % 3 == 0)) {
                    count++;
                }
            }

            return count;
        }

        public static int[] GetArrayFromFile(string fullFilePath) {

            try {
                StreamReader sr = new StreamReader(fullFilePath);

                string arrayStr = "";

                while (!sr.EndOfStream) {
                    arrayStr += Convert.ToInt32(sr.ReadLine()) + " ";
                }

                // To remove last SPACE at the end of the string
                // before converting it to an array
                arrayStr = arrayStr.Trim();

                string[] arrayStrArr = arrayStr.Split(' ');

                int[] arr = new int[arrayStrArr.Length];

                for (int i = 0; i < arrayStrArr.Length; i++) {
                    arr[i] = Convert.ToInt32(arrayStrArr[i]);
                }

                sr.Close();

                return arr;

            } catch (FileNotFoundException exception) {
                Console.WriteLine("File Not Found!");
                Console.WriteLine(exception.Message);
                return new int[] { };
            }
        }
    }

    public struct Account
    {
        
        public string Login;
        public string Password;
        private static string[,] _credentials;

        public static string[,] GetCredentials(string fileName) {

            StreamReader sr = new StreamReader(fileName);

            string credentialsStr = "";
            int credentialsCount = 0;

            while (!sr.EndOfStream) {
                credentialsStr += sr.ReadLine() + "\n";
                credentialsCount++;
            }

            sr.Close();

            _credentials = new string[credentialsCount, 2];

            for (int i = 0; i < credentialsCount; i++) {
                _credentials[i, 0] = credentialsStr.Split('\n')[i].Split(' ')[0];
                _credentials[i, 1] = credentialsStr.Split('\n')[i].Split(' ')[1];
            }

            return _credentials;

        }

        public bool IsAuthentificated() {
            for (int i = 0; i < _credentials.GetLength(0); i++) {
                if (_credentials[i, 0].Equals(this.Login) && _credentials[i, 1].Equals(this.Password)) {
                    return true;
                }
            }
            return false;
        }

    }

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
            void Task2() {
                Console.Clear();
                Console.WriteLine("Task2");
                Console.WriteLine(
                    "Дан целочисленный массив из 20 элементов.\n" +
                    "Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.\n" +
                    "Заполнить случайными числами.\n" +
                    "Написать программу, позволяющую найти и вывести количество пар элементов массива,\n" +
                    "в которых только одно число делится на 3.\n" +
                    "В данной задаче под парой подразумевается два подряд идущих элемента массива.\n" +
                    "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ 2.\n\n" +
                    "Реализуйте задачу в виде статического класса StaticClass:\n" +
                    "\tа)   Класс должен содержать статический метод, который принимает на вход массив и решает задачу;\n" +
                    "\tб)  *Добавьте статический метод для считывания массива из текстового файла.\n" +
                    "\t     Метод должен возвращать массив целых чисел;\n" +
                    "\tв) **Добавьте обработку ситуации отсутствия файла на диске.\n\n"
                );

                int[] arr = ArrayPairs.GetArrayFromFile(@"../../lesson004_task2_array.txt");

                if (arr.Length != 0) {
                    Console.Write("Array: ");
                }

                for (int i = 0; i < arr.Length; i++) {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                if (arr.Length != 0) {
                    Console.WriteLine($"\nAmount of pairs with only one number divisible by 3 with no remainder is {ArrayPairs.CountPairs(arr)}.\n");
                }

                Console.Write("Press any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task3
            void Task3() {
                Console.Clear();
                Console.WriteLine("Task3");
                Console.WriteLine(
                    "\nДописать класс для работы с одномерным массивом:\n\n" +
                    "- Реализовать конструктор, создающий массив определенного размера\n" +
                    "  и заполняющий массив числами от начального значения с заданным шагом.\n\n" +
                    "- Создать свойство Sum, которое возвращает сумму элементов массива,\n\n" +
                    "- Метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива\n" +
                    "  (старый массив, остается без изменений),\n\n" +
                    "- Метод Multi, умножающий каждый элемент массива на определённое число,\n\n" +
                    "- Свойство MaxCount, возвращающее количество максимальных элементов.\n\n" +
                    "**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки.\n\n" +
                    "***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int, int>).\n\n"
                );

                MyArray arr = new MyArray(5, 0, 2);

                Console.WriteLine($"Array: {arr}");

                Console.WriteLine($"Sum of all elements: {arr.Sum}");

                Console.WriteLine($"Multiply all elements by 2: {arr.Multi(2)}");

                Console.WriteLine($"Amount of the largest elements which is {arr.MaxValue} in array is {arr.MaxCount()}");

                Console.Write("New array inverted: ");
                int[] arr2 = arr.Inverse();
                foreach (int value in arr2) {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();

                int min = 0;
                int max = 10;
                int dimension = 20;
                MyArray arrayForFrequency = new MyArray(dimension, 0);
                arrayForFrequency.PopulateWithRandomNumbers(min, max);

                Console.WriteLine($"Array for counting frequency: {arrayForFrequency}");

                Dictionary<int, int> numbersFrequency = new Dictionary<int, int>();

                for (int i = 0; i < dimension; i++) {
                    if (!numbersFrequency.ContainsKey(arrayForFrequency[i])) {
                        numbersFrequency.Add(arrayForFrequency[i], 1);
                    } else {
                        numbersFrequency[arrayForFrequency[i]]++;
                    }
                }

                foreach (KeyValuePair<int, int> key in numbersFrequency.OrderBy(key => key.Key)) {
                    Console.WriteLine($"Number {key.Key} occurs {key.Value}" +
                        (key.Value == 1 ? " time" : " times"));
                }

                Console.Write("Press any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task4
            void Task4() {

                int authentificationTries = 3;
                ConsoleColor initialColor = Console.ForegroundColor;
                
                Console.Clear();
                Console.WriteLine("Task4");
                Console.WriteLine(
                    "\nРешить задачу с логинами из урока 2.\n\n" +
                    "Логины и пароли считать из файла в массив.\n" +
                    "Создайте структуру Account, содержащую Login и Password.\n\n"
                );

                Account account;
                account.Login = "";
                account.Password = "";
                string[,] credentials = Account.GetCredentials("../../credentials.txt");

                do {
                    Console.WriteLine("\nPlease login into your account.");

                    Console.Write("Enter login: ");
                    string login = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    account.Login = login;
                    account.Password = password;

                    if (account.IsAuthentificated()) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are in! Welcome back!\n");
                        Console.ForegroundColor = initialColor;
                        break;
                    } else {
                        authentificationTries--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Intruder alert! Intruder alert!");
                        Console.ForegroundColor = initialColor;
                    }

                } while (authentificationTries > 0);

                Console.Write("Press any key to return to the menu...");
                Console.ReadKey();

            }
            #endregion

            #region Task5
            void Task5() {
                Console.Clear();
                Console.WriteLine("Task5");
                Console.WriteLine(
                    "\nРеализовать библиотеку с классом для работы с двумерным массивом.\n" +
                    "Реализовать конструктор, заполняющий массив случайными числами.\n" +
                    "\nСоздать:\n" +
                    " - метод, который возвращает сумму всех элементов массива,\n" +
                    " - сумму всех элементов массива больше заданного,\n" +
                    " - свойство, возвращающее минимальный элемент массива,\n" +
                    " - свойство, возвращающее максимальный элемент массива,\n" +
                    " - метод, возвращающий номер максимального элемента массива\n" +
                    "  (через параметры, используя модификатор ref или out).\n\n" +
                    "** Добавить конструктор и методы, которые загружают данные из файла\n" +
                    "   и записывают данные в файл.\n" +
                    "** Обработать возможные исключительные ситуации при работе с файлами.\n\n"
                );

                Array2d arr2d = new Array2d(5, 0, 10);
                int[] maxElemIndex;
                arr2d.IndexOfBiggestElement(out maxElemIndex);
                Console.WriteLine("Array:");
                Console.WriteLine(arr2d);
                Console.WriteLine($"Sum of all elements: {arr2d.Sum()}");
                Console.WriteLine($"Sum of all elements greater than 5: {arr2d.SumOfGreaterThan(5)}");
                Console.WriteLine($"Minimal element is {arr2d.Min}");
                Console.WriteLine($"Maximal element is {arr2d.Max} and its first occurance " +
                    $"is in position [{maxElemIndex[0]}, {maxElemIndex[1]}]");

                Array2d arr2d2 = new Array2d("lesson004_task5_array2d.txt");
                Console.WriteLine($"Array from file:\n{arr2d2}");

                Array2d arr2d3 = new Array2d();
                arr2d3.readFromFile("lesson004_task5_array2d.txt");
                Console.WriteLine($"Created a new Array2d and populted it with data from file:\n{arr2d3}");

                arr2d2.writeToFile("lesson004_task5_array2d2_saved.txt");

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
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
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Task3();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Task4();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Task5();
                        break;
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
