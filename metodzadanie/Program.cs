using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodzadanie
{
    internal class Program
    {
        static int summa()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            return sum;
        }
        static int minus()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int minus = num1 - num2;
            return minus;
        }
        static int umnoz()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int umn = num1 * num2;
            return umn;
        }
        static int del()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int del = num1 / num2;
            return del;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("калькулятор");
            Console.WriteLine("Выберите +,-,*,/");
            string lol = Console.ReadLine();
            switch (lol)
            {
                case "+":
                    Console.WriteLine(summa());
                    break;
                case "-":
                    Console.WriteLine(minus());
                    break;
                case "*":
                    Console.WriteLine(umnoz());
                    break;
                case "/":
                    Console.WriteLine(del());
                    break;

            }
        }
    }
}
