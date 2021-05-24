/******************************************************************
 * Константин Войцеховский
 * 
 * Урок 3
 ******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson003_Homework
{
    struct ComplexStruct {
        public double im;
        public double re;

        public ComplexStruct Add(ComplexStruct x2) {
            ComplexStruct x3 = new ComplexStruct();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public ComplexStruct Subtract(ComplexStruct x2) {
            ComplexStruct x3 = new ComplexStruct();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        public override string ToString() {
            return im > 0 ? (re + "+" + im + "i") : (re + "" + im + "i");
        }
    }


    class Complex {
        private double _im;
        private double _re;

        public Complex() {
            this._im = 0;
            this._re = 0;
        }

        public Complex(double im, double re) {
            this._im = im;
            this._re = re;
        }

        public Complex Add(Complex x2) {
            Complex x3 = new Complex();
            x3._im = x2._im + _im;
            x3._re = x2._re + _re;
            return x3;
        }

        public Complex Subtract(Complex x2) {
            Complex x3 = new Complex();
            x3._im = this._im - x2._im;
            x3._re = this._re - x2._re;
            return x3;
        }

        public Complex Multiply(Complex x2) {
            Complex x3 = new Complex();
            x3._re = this._re * x2._re - this._im * x2._im;
            x3._im = this._re * x2._im + this._im * x2._re;
            return x3;
        }

        public double Im {
            get { return this._im; }
            set {
                if (value >= 0) {
                    this._im = value;
                }
            }
        }

        public double Re {
            get { return this._re; }
            set {
                if (value >= 0) {
                    this._re = value;
                }
            }
        }

        public override string ToString() {
            return this._im > 0 ? (this._re + "+" + this._im + "i") : (this._re + "" + this._im + "i");
        }
    }


    class Fraction {
        private int _numerator;
        private int _denominator;

        public Fraction() {
            this._numerator = 1;
            this._denominator = 1;
        }

        public Fraction(int numerator, int denominator) {
            this._numerator = numerator;
            this._denominator = denominator;
        }

        public Fraction Add(Fraction f2) {
            Fraction f3 = new Fraction();
            if (this.Denominator == f2.Denominator) {
                f3.Numerator = this.Numerator + f2.Numerator;
                f3.Denominator = this.Denominator;
            } else {
                f3.Numerator = this.Numerator * f2.Denominator + f2.Numerator * this.Denominator;
                f3.Denominator = this.Denominator * f2.Denominator;
            }
            return f3;
        }

        public Fraction Subtract(Fraction f2) {
            Fraction f3 = new Fraction();
            if (this.Denominator == f2.Denominator) {
                f3.Numerator = this.Numerator - f2.Numerator;
                f3.Denominator = this.Denominator;
            } else {
                f3.Numerator = this.Numerator * f2.Denominator - f2.Numerator * this.Denominator;
                f3.Denominator = this.Denominator * f2.Denominator;
            }
            return f3;
        }

        public Fraction Multiply(Fraction f2) {
            Fraction f3 = new Fraction();
            f3.Numerator = this.Numerator * f2.Numerator;
            f3.Denominator = this.Denominator * f2.Denominator;
            return f3;
        }

        public Fraction Divide(Fraction f2) {
            Fraction f3 = new Fraction();
            f3.Numerator = this.Numerator * f2.Denominator;
            f3.Denominator = this.Denominator * f2.Numerator;
            return f3;
        }

        public int Numerator {
            get { return this._numerator; }
            set { this._numerator = value; }
        }

        public int Denominator {
            get { return this._denominator; }
            set { this._denominator = value; }
        }

        public double Decimal {
            get { return (double)this.Numerator / (double)this.Denominator; }
        }

        public override string ToString() {
            return this.Numerator + "/" + this.Denominator;
        }

    }

    



    class Program
    {

        static bool Simplifable(Fraction f) {
            return GreatestCommonDivisor(f.Numerator, f.Denominator) > 1;
        }

        static Fraction Simplify(Fraction f) {
            Fraction fRes = new Fraction(f.Numerator, f.Denominator);
            int gcd = GreatestCommonDivisor(fRes.Numerator, fRes.Denominator);
            if (Simplifable(fRes)) {
                fRes.Numerator /= gcd;
                fRes.Denominator /= gcd;
            }
            return fRes;
        }

        static int GreatestCommonDivisor(int a, int b) {
            if (a == 0) {
                return Math.Abs(b);
            }

            if (b == 0) {
                return Math.Abs(a);
            }

            if (a == b) {
                return Math.Abs(a);
            }

            if (a > b) {
                return GreatestCommonDivisor(Math.Abs(a) - Math.Abs(b), Math.Abs(b));
            } else {
                return GreatestCommonDivisor(Math.Abs(a), Math.Abs(b) - Math.Abs(a));
            }
        }

        #region Task1
        static void Task1() {
            Console.Clear();
            Console.WriteLine("Task1");
            Console.WriteLine(
                "а) Дописать структуру Complex, добавив метод вычитания комплексных чисел." +
                "Продемонстрировать работу структуры.\n" +
                "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса." +
                "в) Добавить диалог с использованием switch демонстрирующий работу класса."
            );

            Console.Write("\nВведите через пробел действительную и мнимую части комплексного числа A: ");
            string num1Str = Console.ReadLine();
            
            ComplexStruct num1Struct = new ComplexStruct();
            num1Struct.re = int.Parse(num1Str.Split(' ')[0]);
            num1Struct.im = int.Parse(num1Str.Split(' ')[1]);

            Complex num1 = new Complex();
            num1.Re = int.Parse(num1Str.Split(' ')[0]);
            num1.Im = int.Parse(num1Str.Split(' ')[1]);


            Console.Write("Введите через пробел действительную и мнимую части комплексного числа B: ");
            string num2Str = Console.ReadLine();

            ComplexStruct num2Struct = new ComplexStruct();
            num2Struct.re = int.Parse(num2Str.Split(' ')[0]);
            num2Struct.im = int.Parse(num2Str.Split(' ')[1]);

            Complex num2 = new Complex();
            num2.Re = int.Parse(num2Str.Split(' ')[0]);
            num2.Im = int.Parse(num2Str.Split(' ')[1]);


            Console.WriteLine("\nИспользуется структура ComplexStruct:");
            Console.WriteLine($"{num1Struct} + {num2Struct} = {num1Struct.Add(num2Struct)}");
            Console.WriteLine($"{num1Struct} - {num2Struct} = {num1Struct.Subtract(num2Struct)}");

            Console.WriteLine("\nИспользуется класс Complex:");
            Console.WriteLine($"{num1} + {num2} = {num1.Add(num2)}");
            Console.WriteLine($"{num1} - {num2} = {num1.Subtract(num2)}");
            Console.WriteLine($"{num1} × {num2} = {num1.Multiply(num2)}");


            Console.WriteLine("\n\n");


            bool flag = false;
            ConsoleKeyInfo choice;

            do {

                Console.WriteLine(
                    "=============================================================\n" +
                    "1. сложение\n" +
                    "2. вычитание\n" +
                    "3. умножение\n" +
                    "0. выход\n" +
                    "============================================================="
                );

                Console.Write($"Выберите операцию над комплексными числами {num1} и {num2}: ");

                choice = Console.ReadKey(false);

                switch (choice.Key) {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine($"\n{num1} + {num2} = {num1.Add(num2)}");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine($"\n{num1} - {num2} = {num1.Subtract(num2)}");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"\n{num1} × {num2} = {num1.Multiply(num2)}");
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
        #endregion

        #region Task2
        static void Task2() {
            Console.Clear();
            Console.WriteLine("Task2");
            Console.WriteLine(
                "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).\n" +
                "Требуется подсчитать сумму всех нечётных положительных чисел.\n" +
                "Сами числа и сумму вывести на экран, используя tryParse.\n"
            );

            Console.Write("Вводите целые числа.\nДля завершения ввода данных введите ноль:\n");

            string numberStr;
            int numberInt;
            int sum = 0;
            int count = 0;
            bool flag;

            do {
                do {
                    Console.Write($"{count + 1}: ");
                    numberStr = Console.ReadLine();
                    flag = int.TryParse(numberStr, out numberInt);
                } while (!flag);

                if (numberInt != 0) {
                    count++;
                }

                if ((numberInt % 2 != 0) && (numberInt > 0)) {
                    sum += numberInt;
                }

            } while (numberStr != "0");

            Console.WriteLine($"Среди введенных {count} целых чисел сумма всех положительных нечётных составляет {sum}.");
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }
        #endregion

        #region Task3
        static void Task3() {
            Console.Clear();
            Console.WriteLine("Task3");
            Console.WriteLine(
                "Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.\n" +
                "Предусмотреть методы сложения, вычитания, умножения и деления дробей.\n" +
                "Написать программу, демонстрирующую все разработанные элементы класса.\n\n" +
                "\t*   Добавить свойства типа int для доступа к числителю и знаменателю;\n" +
                "\t*   Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;\n" +
                "\t**  Добавить проверку, чтобы знаменатель не равнялся 0.\n" +
                "\t    Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\");\n" +
                "\t*** Добавить упрощение дробей.\n"
            );

            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();

            Console.Write("Введите дробь 1 через /, например, 1/2:");
            string f1Str = Console.ReadLine();
            if (Convert.ToInt32(f1Str.Split('/')[1]) == 0) {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            } else {
                f1 = new Fraction(Convert.ToInt32(f1Str.Split('/')[0]), Convert.ToInt32(f1Str.Split('/')[1]));
            }

            Console.Write("Введите дробь 2 через /, например, 1/2:");
            string f2Str = Console.ReadLine();
            if (Convert.ToInt32(f2Str.Split('/')[1]) == 0) {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            } else {
                f2 = new Fraction(Convert.ToInt32(f2Str.Split('/')[0]), Convert.ToInt32(f2Str.Split('/')[1]));
            }

            f3 = f1.Add(f2);
            Console.Write(f1 + " + " + f2 + " = " + f3);
            if (Simplifable(f3)) {
                Console.Write(" или " + Simplify(f3));
            }
            Console.WriteLine(" или " + f3.Decimal);

            f3 = f1.Subtract(f2);
            Console.Write(f1 + " — " + f2 + " = " + f3);
            if (Simplifable(f3)) {
                Console.Write(" или " + Simplify(f3));
            }
            Console.WriteLine(" или " + f3.Decimal);

            f3 = f1.Multiply(f2);
            Console.Write(f1 + " × " + f2 + " = " + f3);
            if (Simplifable(f3)) {
                Console.Write(" или " + Simplify(f3));
            }
            Console.WriteLine(" или " + f3.Decimal);

            f3 = f1.Divide(f2);
            Console.Write(f1 + " ÷ " + f2 + " = " + f3);
            if (Simplifable(f3)) {
                Console.Write(" или " + Simplify(f3));
            }
            Console.WriteLine(" или " + f3.Decimal);

            Console.Write("Нажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args) {

            bool flag = false;

            ConsoleKeyInfo choice;

            Console.OutputEncoding = Encoding.Unicode;

            do {
                Console.Clear();
                Console.WriteLine(
                    "\n\n" +
                    "=======================================\n" +
                    "Урок 3: Домашняя работа\n" +
                    "=======================================\n" +
                    "1. Комплексные числа\n" +
                    "2. Сумма всех позитивных нечётных чисел\n" +
                    "3. Дроби\n" +
                    "0. Выход\n" +
                    "======================================="
                );

                Console.Write("Сделайте выбор: ");

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
