using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napare
{
    internal class Program
    {
        static int CalculateSizeDiscount(double price)
        {
            if (price >= 10000)
                return 15;
            else if (price >= 5000)
                return 10;
            else 
                return 5;
        }
        static double CalculateFinalPrice(double price, double discount)
        {
            double sumDisc = price * (discount/ 100);
            return price - sumDisc;
        }
        static void Ticket(double price)
        {
            double procent = CalculateSizeDiscount(price);
            double finalSum = CalculateFinalPrice(price, procent);

            Console.WriteLine("    Чек покупки    ");
            Console.WriteLine($"Сумма покупки: {price}");
            Console.WriteLine($"Скидка: {procent}");
            Console.WriteLine($"К оплате: {finalSum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки:");

            if
        }
    }
}
