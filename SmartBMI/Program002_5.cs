/******************************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 5.
 * 
 * A) Написать программу, которая запрашивает массу и рост человека,
 * вычисляет его индекс массы и сообщает, нужно ли человеку
 * похудеть, набрать вес или всё в норме.
 * 
 * B) *Рассчитать, на сколько кг похудеть или сколько кг набрать
 * для нормализации веса.
 ******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBMI
{
    class Program002_5
    {
        const double BMI_MIN = 18.5;
        const double BMI_MAX = 25;

        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            int initialConsoleCursorSize = Console.CursorSize;
            ConsoleColor initialConsoleForegroundColor = Console.ForegroundColor;
            Console.CursorSize = 100;

            Console.Write("Please enter your height (m): ");
            string heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);

            Console.Write("Enter your weight (kg): ");
            string weightStr = Console.ReadLine();
            double weight = Convert.ToDouble(weightStr);

            double indexBMI = calculateBMI(height, weight);

            Console.WriteLine("Your BMI index is {0:F2}.", indexBMI);

            if (indexBMI > BMI_MAX) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uh-oh, you are obese... Please lose some weight!");
                writeAdvice(weightChange(height, weight));
            } else if (indexBMI <= BMI_MAX && indexBMI >= BMI_MIN) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey! Your weight is totally healthy. Congrats!");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ts-ts-ts... You look thin... Please gain some weight!");
                writeAdvice(weightChange(height, weight));
            }

            Console.ForegroundColor = initialConsoleForegroundColor;
            Console.CursorSize = initialConsoleCursorSize;

        }


        /*
         * calculateBMI(double height, double weight) calculates BMI
         */
        static double calculateBMI(double height, double weight) {
            return weight / height * height;
        }


        /*
         * weightChange(double height, double weight) calculates
         * how many kg person needs to gain or lose
         * in order to get healthy BMI.
         */
        static double[] weightChange(double height, double weight) {
            
            double[] result = { 0, 0 };
            
            double bmi = calculateBMI(height, weight);
            
            double changeWeightToGetBMIMin = weight - BMI_MIN * height * height;
            double changeWeightToGetBMIMax = weight - BMI_MAX * height * height;
            
            if (changeWeightToGetBMIMin < changeWeightToGetBMIMax
                || changeWeightToGetBMIMin == changeWeightToGetBMIMax) {
                result[0] = changeWeightToGetBMIMin;
                result[1] = changeWeightToGetBMIMax;
            } else {
                result[0] = changeWeightToGetBMIMax;
                result[1] = changeWeightToGetBMIMin;
            }

            // in order to keep data consistent,
            // when person needs to gain some weight
            // show smaller amount first
            if (changeWeightToGetBMIMin < 0 && changeWeightToGetBMIMax < 0) {
                double temp = result[0];
                result[0] = result[1] * -1;
                result[1] = temp * -1;
            }

            return result;
        }


        /*
         * writeAdvice(double[] changeWeight) is used to write how many kg person needs to gain or lose
         * in order to get healthy BMI.
         * 
         * writeAdive(double[] changeWeight) takes a pair of weights in kg in ascending order.
         */
        static void writeAdvice(double[] changeWeight) {
            Console.WriteLine(
                "You need to "
                + (changeWeight[0] < 0 && changeWeight[1] < 0 ? "gain" : "lose")
                + $" from {changeWeight[0]} to {changeWeight[1]} kg.");
        }
    }
}
