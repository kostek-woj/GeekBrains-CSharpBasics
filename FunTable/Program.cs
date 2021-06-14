using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson006_Homework
{
    class Program
    {

        #region Task1

        public delegate double Fun(double a, double x);


        public static void Table(Fun F, double a, double x, int rows) {

            Console.WriteLine("----- A ------- X ------- Y -------");

            while (x <= rows) {
                Console.WriteLine($"| {a,8:0.000} | {x,8:0.000} | {F(a, x),8:0.000} |");
                x++;
            }

            Console.WriteLine("-----------------------------------");
        }


        public static double MyFun(double a, double x) {
            return a * x * x;
        }


        public static double ASin(double a, double x) {
            return a * Math.Sin(x);
        }

        #endregion


        #region Task2

        public delegate double Fun2(double x);


        public static double SquareFun(double x) {
            return x * x - 50 * x + 10;
        }

        
        public static double PowerEvenPositiveFun(double x) {
            return x * x;
        }


        public static double PowerOddPositiveFun(double x) {
            return x * x * x;
        }


        public static double PowerEvenNegativeFun(double x) {
            return 1 / (x * x);
        }


        public static double PowerOddNegativeFun(double x) {
            return 1 / (x * x * x);
        }


        public static void SaveFun(string fileName, double a, double b, double h, Fun2 F) {
            
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            double x = a;

            while (x <= b) {
                bw.Write(F(x));
                x += h;
            }

            bw.Close();
            fs.Close();

        }


        public static double Load(string fileName) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            double min = double.MaxValue;
            double d;

            for (int i = 0; i < fs.Length / sizeof(double); i++) {
                d = br.ReadDouble();
                if (d < min) {
                    min = d;
                }
            }
            
            br.Close();
            fs.Close();

            return min;
            
        }


        public static double[] LoadInArray(string fileName, out double minimum) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            double min = double.MaxValue;

            double[] arr = new double[fs.Length / sizeof(double)];

            for (int i = 0; i < fs.Length / sizeof(double); i++) {
                arr[i] = br.ReadDouble();
                Console.Write(arr[i] + " ");
                if (arr[i] < min) {
                    min = arr[i];
                }
            }

            br.Close();
            fs.Close();

            minimum = min;

            return arr;

        }

        #endregion


        #region Task3


        static int SortByAge(Student s1, Student s2) {
            return s1.age - s2.age;
        }

        class Student
        {
            public string firstName;
            public string lastName;
            public string university;
            public string faculty;
            public string department;
            public int age { get; private set; }
            public int course;
            public int group;
            public string city;


            public Student(string firstName, string lastName, string university, string faculty,
                string department, int age, int course, int group, string city) {

                this.firstName = firstName;
                this.lastName = lastName;
                this.university = university;
                this.faculty = faculty;
                this.department = department;
                this.age = age;
                this.course = course;
                this.group = group;
                this.city = city;
            }
        }

        #endregion


        #region Task4
        public static long FileStreamWrite(string fileName, long size) {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            for (int i = 0; i < size; i++) {
                fs.WriteByte((byte)i);
            }

            fs.Close();
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;

        }


        public static byte[] FileStreamRead(string fileName) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            byte[] bytes = new byte[fs.Length];
            int numBytesToRead = (int)fs.Length;
            int numBytesRead = 0;

            while (numBytesToRead > 0) {
                int n = fs.Read(bytes, numBytesRead, numBytesToRead);
                if (n == 0) {
                    break;
                }
                numBytesToRead -= n;
                numBytesRead += n;
            }

            fs.Close();

            return bytes;

        }


        public static long BinaryStreamWrite(string fileName, long size) {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < size; i++) {
                bw.Write((byte)i);
            }

            bw.Close();
            fs.Close();
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;

        }


        public static int[] BinaryStreamRead(string fileName) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            int[] intArr = new int[fs.Length / 4];
            
            for (int i = 0; i < fs.Length / 4; i++) {
                intArr[i] = br.ReadInt32();
            }
            
            fs.Close();
            
            return intArr;

        }


        public static long StreamWriterWrite(string fileName, long size) {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < size; i++) {
                sw.Write(i);
            }

            sw.Close();
            fs.Close();
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;

        }


        public static string StreamReaderRead(string fileName) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            string result = sr.ReadToEnd();
            
            fs.Close();
            
            return result;
        }


        public static long BufferedStreamWrite(string fileName, long size) {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int countPart = 4;
            int buffSize = (int)(size / countPart);
            byte[] buffer = new byte[size];

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BufferedStream bs = new BufferedStream(fs, buffSize);

            for (int i = 0; i < countPart; i++) {
                bs.Write(buffer, 0, (int)buffSize);
            }

            bs.Close();
            fs.Close();
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;

        }


        public static byte[] BufferedStreamRead(string fileName) {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            int countPart = 4;
            int buffSize = (int)(fs.Length / countPart);
            byte[] bytes = new byte[fs.Length];
            
            BufferedStream bs = new BufferedStream(fs, buffSize);

            for (int i = 0; i < countPart; i++) {
                bs.Read(bytes, 0, (int)buffSize);
            }

            return bytes;

        }
        #endregion


        static void Main(string[] args) {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Task1
            void Task1() {
                Console.Clear();
                Console.WriteLine("Task1");
                Console.WriteLine(
                    "\nИзменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).\n" +
                    "Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).\n\n"
                );

                Console.WriteLine("Table of the y = a * x^2");
                Table(MyFun, -2, 2, 6);

                Console.WriteLine("\n\nTable of the y = a * sin(x)");
                Table(ASin, -2, 2, 6);

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion


            #region Task2
            void Task2() {

                double intervalStart = -5, intervalEnd = 5, step = 1;
                double minOut;

                bool flag2 = false;
                ConsoleKeyInfo choice2;

                Fun2[] functions = new Fun2[5];
                functions[0] = new Fun2(SquareFun);
                functions[1] = new Fun2(PowerEvenPositiveFun);
                functions[2] = new Fun2(PowerOddPositiveFun);
                functions[3] = new Fun2(PowerEvenNegativeFun);
                functions[4] = new Fun2(PowerOddNegativeFun);


                do {
                    Console.Clear();
                    Console.WriteLine("Task2");
                    Console.WriteLine(
                        "\nМодифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.\n" +
                        "а)   Сделать меню с различными функциями и представить пользователю выбор,\n" +
                        "     для какой функции и на каком отрезке находить минимум.\n" +
                        "     Использовать массив (или список) делегатов, в котором хранятся различные функции.\n" +
                        "б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.\n" +
                        "     Пусть она возвращает минимум через параметр(с использованием модификатора out).\n\n"
                    );

                    //Console.Write("Введите начало интервала функции: ");
                    //intervalStart = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("Введите окончание интервала функции: ");
                    //intervalEnd = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("Введите прирост функции: ");
                    //step = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "\n\n" +
                        "=============================================\n" +
                        "Выберите функцию:\n" +
                        "=============================================\n" +
                        "1. Квадратичная функция x^2 - 50x + 10\n" +
                        "2. Степенная функция x^2\n" +
                        "3. Степенная функция x^3\n" +
                        "4. Степенная функция 1/x^2\n" +
                        "5. Степенная функция 1/x^3\n" +
                        "0. Exit\n" +
                        "============================================="
                    );

                    Console.Write("Вы выбрали функцию под номером: ");

                    choice2 = Console.ReadKey(false);

                    switch (choice2.Key) {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            SaveFun("data.bin", intervalStart, intervalEnd, step, functions[0]);
                            Console.WriteLine("\nМинимум этой функции = " + Load("data.bin"));
                            Console.Write("\nЗначения функции на заданном промежутке: ");
                            Console.Write(LoadInArray("data.bin", out minOut));
                            Console.WriteLine($"\nМинимум этой функции через OUT = {minOut}");
                            Console.Write("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            SaveFun("data.bin", intervalStart, intervalEnd, step, functions[1]);
                            Console.WriteLine("\nМинимум этой функции = " + Load("data.bin"));
                            Console.Write("\nЗначения функции на заданном промежутке: ");
                            Console.Write(LoadInArray("data.bin", out minOut));
                            Console.WriteLine($"\nМинимум этой функции через OUT = {minOut}");
                            Console.Write("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            SaveFun("data.bin", intervalStart, intervalEnd, step, functions[2]);
                            Console.WriteLine("\nМинимум этой функции = " + Load("data.bin"));
                            Console.Write("\nЗначения функции на заданном промежутке: ");
                            Console.Write(LoadInArray("data.bin", out minOut));
                            Console.WriteLine($"\nМинимум этой функции через OUT = {minOut}");
                            Console.Write("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            SaveFun("data.bin", intervalStart, intervalEnd, step, functions[3]);
                            Console.WriteLine("\nМинимум этой функции = " + Load("data.bin"));
                            Console.Write("\nЗначения функции на заданном промежутке: ");
                            Console.Write(LoadInArray("data.bin", out minOut));
                            Console.WriteLine($"\nМинимум этой функции через OUT = {minOut}");
                            Console.Write("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            SaveFun("data.bin", intervalStart, intervalEnd, step, functions[4]);
                            Console.WriteLine("\nМинимум этой функции = " + Load("data.bin"));
                            Console.Write("\nЗначения функции на заданном промежутке: ");
                            Console.Write(LoadInArray("data.bin", out minOut));
                            Console.WriteLine($"\nМинимум этой функции через OUT = {minOut}");
                            Console.Write("\nPress any key to return to the menu...");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                            flag2 = true;
                            break;
                        default:
                            break;
                    }
                } while (!flag2);

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

                int bachelors = 0;
                int masters = 0;
                int students5course = 0;
                int students6course = 0;
                Dictionary<int, int> studentsAge = new Dictionary<int, int>();

                List<Student> students = new List<Student>();
                List<Student> studentsByCourseAndAge = new List<Student>();

                Console.WriteLine("Program started...");

                DateTime start = DateTime.Now;

                StreamReader sr = new StreamReader("StudentsInfo.csv");

                while (!sr.EndOfStream) {
                    try {
                        string[] s = sr.ReadLine().Split(';');
                        students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                        // frequency dictionary of students' age
                        if (!studentsAge.ContainsKey(int.Parse(s[5]))) {
                            studentsAge.Add(int.Parse(s[5]), 1);
                        } else {
                            studentsAge[int.Parse(s[5])]++;
                        }

                        // counting bachelors and masters
                        if (int.Parse(s[6]) < 5) {
                            bachelors++;
                        } else {
                            masters++;

                            // counting students of 5th and 6th course
                            if (int.Parse(s[6]) == 5) {
                                students5course++;
                            } else {
                                students6course++;
                            }
                        }
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Error! Press ESC to terminate the program...");
                        if (Console.ReadKey().Equals(ConsoleKey.Escape)) {
                            return;
                        }
                    }
                }

                sr.Close();

                // sort students by age
                students.Sort(new Comparison<Student>(SortByAge));

                // sort students by course and age
                studentsByCourseAndAge = students.OrderBy(s => s.course).ThenBy(s => s.age).ToList();

                foreach (var s in studentsByCourseAndAge) {
                    Console.WriteLine($"{s.firstName} {s.lastName}\t{s.course}\t{s.age}");
                }



                Console.WriteLine($"\nTotal students: {students.Count}");
                Console.WriteLine($"  - masters: {masters}");
                Console.WriteLine($"    - course 5: {students5course}");
                Console.WriteLine($"    - course 6: {students6course}");
                Console.WriteLine($"  - bachelors: {bachelors}");

                Console.WriteLine("\nTotal students from 18 to 20 years old:");
                foreach (KeyValuePair<int, int> kvp in studentsAge.OrderBy(age => age.Key)) {
                    if (kvp.Key >= 18 && kvp.Key <= 20) {
                        Console.WriteLine($"{kvp.Key} years old: {kvp.Value}");
                    }
                }

                Console.WriteLine("\nProgram ended...");

                DateTime end = DateTime.Now;

                TimeSpan ts = end - start;

                Console.WriteLine($"\nElapsed {ts.Seconds} seconds");

                Console.Write("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            #endregion


            #region Task4
            void Task4() {
                Console.Clear();
                Console.WriteLine("Task4");
                Console.WriteLine(
                    "\n** Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.\n" +
                    "Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader\n" +
                    "и массив int для BinaryReader.\n\n"
                );

                long kbyte = 1024;
                long mbyte = 1024 * kbyte;
                long gbyte = 1024 * mbyte;
                long size = mbyte;

                Console.WriteLine("FileStream Writing.\tElapsed {0} milliseconds.", FileStreamWrite("bigdata0.bin", size));
                Console.WriteLine("FileStream Reading...");
                byte[] fileStreamReadResult = FileStreamRead("bigdata0.bin");

                Console.WriteLine("\nBinaryStream Writing.\tElapsed {0} milliseconds.", BinaryStreamWrite("bigdata1.bin", size));
                Console.WriteLine("BinaryStream Reading...");
                int[] binaryStreamReadResult = BinaryStreamRead("bigdata1.bin");

                Console.WriteLine("\nStreamWriter.\tElapsed {0} milliseconds.", StreamWriterWrite("bigdata2.bin", size));
                Console.WriteLine("StreamReader Reading...");
                string streamReaderResult = StreamReaderRead("bigdata2.bin");

                Console.WriteLine("\nBufferedStream Writing.\tElapsed {0} milliseconds.", BufferedStreamWrite("bigdata3.bin", size));
                Console.WriteLine("BufferedStream Reading...");
                byte[] bufferedStreamReadResult = BufferedStreamRead("bigdata3.bin");

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
                    "Lesson 6: Homework\n" +
                    "=============================================\n" +
                    "1. Function Table\n" +
                    "2. Function Minimum\n" +
                    "3. Students Collection\n" +
                    "4. Read a File\n" +
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
