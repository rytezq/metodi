using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domzad
{
    internal class Program
    {
        static string GetTextTone(string text)
        {
            string[] positiveWords = { "хороший", "отличный", "прекрасный", "супер", "круто",
                                  "люблю", "нравится", "классно", "здорово", "рад", "ура" };

            string[] negativeWords = { "плохой", "ужасный", "скучный", "грустный", "ненавижу",
                                 "не нравится", "отвратительно", "кошмар", "проблема" };

            string lowerText = text.ToLower();
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (string word in positiveWords)
            {
                if (lowerText.Contains(word))
                    positiveCount++;
            }

            foreach (string word in negativeWords)
            {
                if (lowerText.Contains(word))
                    negativeCount++;
            }

            if (positiveCount > negativeCount)
                return "Позитивный";
            else if (negativeCount > positiveCount)
                return "Негативный";
            else if (positiveCount == 0 && negativeCount == 0)
                return "Нейтральный";
            else
                return "Смешанный";
        }
        static int CountUniqueWords(string text)
        {
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-' },
                       StringSplitOptions.RemoveEmptyEntries);

            return words.Distinct().Count();
        }
        static void AnalyzeTexts()
        {
            Console.WriteLine("--- Анализ текстов ---");
            Console.WriteLine("Введите 'стоп' для завершения анализа");

            int textNumber = 1;

            while (true)
            {
                Console.Write($"Текст {textNumber}: ");
                string text = Console.ReadLine();

                if (text.ToLower() == "стоп")
                    break;

                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Результаты:");
                    Console.WriteLine($"Уникальных слов: {CountUniqueWords(text)}");
                    Console.WriteLine($"Тон текста: {GetTextTone(text)}");
                    Console.WriteLine("--------------------");

                    textNumber++;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=== АНАЛИЗАТОР ТЕКСТА ===");
                Console.WriteLine("1. Начать анализ");
                Console.WriteLine("2. Выйти");
                Console.Write("Выберите: ");

                string choice = Console.ReadLine();

                if (choice == "2")
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                else if (choice == "1")
                {
                    AnalyzeTexts();
                }
                else
                {
                    Console.WriteLine("Неверный выбор!");
                }
            }
        }
    }
}
