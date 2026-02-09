using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodi
{
    internal class Program
    {
        static int AddNumbers()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            return sum;
        }
        static void CheckEven()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
        static void CalculateDicount()
        {
            Console.WriteLine("Введите цену товара:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент скидки:");
            double discount = Convert.ToDouble(Console.ReadLine());

            double discountAmount = price * (discount / 100);
            double finalPrice= price - discountAmount;
            Console.WriteLine($"Начальная цена: {price}");
            Console.WriteLine($"Финальная цена: {finalPrice}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма чисел:");
            Console.WriteLine(AddNumbers());
            Console.WriteLine(AddNumbers());
            Console.WriteLine(AddNumbers());

            Console.WriteLine("Проверка четности:");
            CheckEven();
            CheckEven();
            CheckEven();

            Console.WriteLine("Расчет скидки:");
            CalculateDicount();
            CalculateDicount();
            CalculateDicount();
        }
    }
}
