using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Message.Message;
using ExamResultsLib;

namespace Lesson005_Homework
{
    class Program
    {
        public static Dictionary<char, int> CharsInStringFrequency(string s) {
            char[] sChars = s.ToCharArray();
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in sChars) {
                if (!frequency.ContainsKey(c)) {
                    frequency.Add(c, 1);
                } else {
                    frequency[c]++;
                }
            }

            return frequency;
        }


        public static bool CompareStrings(string s1, string s2) {

            bool result;
            Dictionary<char, int> frequency1 = CharsInStringFrequency(s1);
            Dictionary<char, int> frequency2 = CharsInStringFrequency(s2);
            Dictionary<char, int> difference = new Dictionary<char, int>(); // key:value not present in both frequency1 and in frequency2

            foreach (KeyValuePair<char, int> kvp in frequency1) {
                if (!frequency2.ContainsKey(kvp.Key) || frequency2[kvp.Key] != kvp.Value) {
                    difference.Add(kvp.Key, kvp.Value);
                }
            }

            if (s1.Length == s2.Length && frequency1.Count == frequency2.Count && difference.Count == 0) {
                result = true;
            } else {
                result = false;
            }

            return result;
        }


        static void Main(string[] args) {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Task1
            void Task1() {
                Console.Clear();
                Console.WriteLine("Task1");
                Console.WriteLine(
                    "\nСоздать программу, которая будет проверять корректность ввода логина.\n" +
                    "Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,\n" +
                    "при этом цифра не может быть первой:\n" +
                    "   а) без использования регулярных выражений\n" +
                    "** б) с использованием регулярных выражений\n\n"
                );

                string login = "";
                bool isPassed = false;

                //do {
                //    bool isLettersOrNumbers = true;

                //    Console.Write("Enter login: ");
                //    login = Console.ReadLine();

                //    if (login.Length >= 2 && login.Length <= 10) {
                //        if (Char.IsDigit(login[0])) {
                //            Console.WriteLine("Login cannot start with a number!");
                //        } else {
                //            for (int i = 0; i < login.Length; i++) {
                //                if (!Char.IsLetterOrDigit(login[i])) {
                //                    isLettersOrNumbers = false;
                //                }
                //            }
                //            if (!isLettersOrNumbers) {
                //                Console.WriteLine("Login must contain latin letters and/or digits only!");
                //            } else {
                //                isPassed = true;
                //            }
                //        }
                //    } else {
                //        Console.WriteLine("Wrong login length!");
                //    }
                //} while (!isPassed);


                Regex regex = new Regex(@"^[^0-9][a-zA-Z0-9]{1,9}$");
                login = "";
                isPassed = false;

                Console.WriteLine("\nNow with regular expressions:");

                do {
                    Console.Write("Enter login: ");
                    login = Console.ReadLine();
                    if (regex.IsMatch(login)) {
                        isPassed = true;
                    } else {
                        Console.WriteLine("Wrong login format!");
                    }
                } while (!isPassed);

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task2
            void Task2() {
                Console.Clear();
                Console.WriteLine("Task2");
                Console.WriteLine(
                    "\nРазработать статический класс Message, содержащий следующие\n" +
                    "статические методы для обработки текста:\n" +
                    "    а) Вывести только те слова сообщения, которые содержат не более n букв.\n" +
                    "    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.\n" +
                    "    в) Найти самое длинное слово сообщения.\n" +
                    "    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.\n" +
                    "*** д) Создать метод, который производит частотный анализ текста.\n" +
                    "       В качестве параметра в него передается массив слов и текст,\n" +
                    "       в качестве результата метод возвращает сколько раз каждое из слов массива\n" +
                    "       входит в этот текст. Здесь требуется использовать класс Dictionary.\n\n"
                );

                string text = "Создать корректнейше программу, которая будет логином проверять программу и корректность ввода логина. " +
                    "Корректным логином будет строка от 2 до 10 символов, логином прекраснейше содержащая только программу буквы латинского алфавита" +
                    "или цифры, при этом цифра не не не не не может быть первой";
                Console.WriteLine("Source text:\n" + text);
                
                PrintWordsShorterThanN(text, 5);

                Console.WriteLine("\n\nRemove all words ending with 'ь':");
                RemoveWordsEndingIn(text, 'ь');

                Console.WriteLine($"\n\nFirst longest word in the text above is \"{LongestWord(text)}\". Its length is {LongestWord(text).Length}.");

                LongestWordsString(text);

                Console.WriteLine("\n\nFrequency text analysis:");

                FrequencyTextAnalysis(text);

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task3
            void Task3() {
                Console.Clear();
                Console.WriteLine("Task3");
                Console.WriteLine(
                    "\n* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.\n" +
                    "Например: badc являются перестановкой abcd.\n\n"
                );

                Console.Write("Enter string1: ");
                string str1 = Console.ReadLine();
                Console.Write("Enter string2: ");
                string str2 = Console.ReadLine();

                if (CompareStrings(str1, str2)) {
                    Console.WriteLine("Strings 1 and 2 are premutable.");
                } else {
                    Console.WriteLine("Strings 1 and 2 are not premutable.");
                }

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion

            #region Task4
            void Task4() {
                Console.Clear();
                Console.WriteLine("Task4");
                Console.WriteLine(
                    "\nНа вход программе подаются сведения о сдаче экзаменов учениками 9-х классов" +
                    "некоторой средней школы. В первой строке сообщается количество учеников N," +
                    "которое не меньше 10, но не превосходит 100, каждая из следующих N строк" +
                    "имеет следующий формат: < Фамилия > < Имя > < оценки >,\n" +
                    "   где < Фамилия > — строка, состоящая не более чем из 20 символов,\n" +
                    "       < Имя > — строка, состоящая не более чем из 15 символов,\n" +
                    "       < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.\n\n" +
                    "< Фамилия > и < Имя >, а также < Имя > и < оценки > разделены одним пробелом.\n" +
                    "Пример входной строки: Иванов Петр 4 5 3\n" +
                    "Требуется написать как можно более эффективную программу, которая будет выводить на экран" +
                    "фамилии и имена трёх худших по среднему баллу учеников.\n" +
                    "Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших," +
                    "следует вывести и их фамилии и имена.\n\n"
                );

                ExamResults results = new ExamResults("exam results.txt");

                results.PrintThreeWorstAndOthersWithTheSameMedianMark();

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
                    "=============================================\n" +
                    "Lesson 5: Homework\n" +
                    "=============================================\n" +
                    "1. Correct login\n" +
                    "2. Static class Message for text manipulation\n" +
                    "3. Permutation of two strings\n" +
                    "4. Examination table\n" +
                    "0. Exit\n" +
                    "============================================="
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
