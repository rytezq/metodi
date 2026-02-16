using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Program
    {
        static bool CheckLength(string password)
        {
            return password.Length >= 8;
        }
        static bool CheckDigit(string password)
        {
            return password.Any(char.IsDigit);
        }
        static bool CheckUpper(string password)
        {
            return password.Any(char.IsUpper);
        }
        static bool IsPasswordStrong(string password)
        {
            return CheckLength(password) && CheckDigit(password) && CheckUpper(password);
        }
        static void PrintReport(string password)
        {
            Console.WriteLine("---Отчет о проверке пароля---");

            bool length = CheckLength(password);
            bool digit = CheckDigit(password);
            bool upper = CheckUpper(password);
            bool strong = IsPasswordStrong(password);

            Console.WriteLine($"Длина пароля больше 8 : {(length ? "Да" : "Нет")}");
            Console.WriteLine($"Пароль содержит цифры : {(digit ? "Да" : "Нет")}");
            Console.WriteLine($"Пароль содержит заглавные буквы : {(upper ? "Да" : "Нет")}");
            Console.WriteLine($"Пароль надежный: {(strong ? "Да" : "Нет")}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите пароль для проверки:");
            string password = Console.ReadLine();
            PrintReport(password);
        }
    }
}
