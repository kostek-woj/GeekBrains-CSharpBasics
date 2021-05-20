/******************************************************************
 * Константин Войцеховский
 * 
 * Урок 2. Задача 4.
 * 
 * Реализовать метод проверки логина и пароля.
 * На вход метода подается логин и пароль.
 * На выходе истина, если прошел авторизацию, и ложь,
 * если не прошел (Логин: root, Password: GeekBrains).
 * 
 * Используя метод проверки логина и пароля, написать программу:
 * пользователь вводит логин и пароль, программа пропускает
 * его дальше или не пропускает.
 * 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 ******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
    class Program002_4
    {
        const string LOGIN = "root";
        const string PASSWORD = "GeekBrains";
        const int ATTEMPTS = 3;

        static bool isAuthentificated(string login, string password) {
            return login.Equals(LOGIN) && password.Equals(PASSWORD);
        }

        static string GetPassword() {
            
            string password = "";
            ConsoleKeyInfo key;
            
            do {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter) {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            return password;
        }

        static void Main(string[] args) {

            int attemptsOfAuthentification = 1;

            Console.Write("Enter login: ");
            string loginStr = Console.ReadLine();

            do {
                Console.Write($"Enter password. Attempt {attemptsOfAuthentification} of {ATTEMPTS}: ");
                string passwordStr = GetPassword();

                if (!isAuthentificated(loginStr, passwordStr)) {
                    attemptsOfAuthentification++;
                } else {
                    Console.WriteLine("Welcome to your account!");
                    // Account mechanics
                    break;
                }
            } while (attemptsOfAuthentification <= ATTEMPTS);

            Console.WriteLine("Login and Password provided cannot let you proceed further.");
        }
    }
}
