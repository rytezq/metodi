using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodi1
{
    internal class Program
    {
        static int CountWords(string text)
        {
            string[] words = text.Split(new char[] {' ','.',',','!','?',';',':'}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static int CountSymbolsWithoutSpaces(string text)
        {
            int counter = 0;
            foreach(char symol in text)
            {
                if (symol != ' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        static string SearchVeryLongWord(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string veruLong = "";
            foreach(string word in words)
            {
                if(word.Length > veruLong.Length)
                {
                    veruLong = word;
                }
            }
            return veruLong;
        }
        static bool IsItQuestion(string text)
        {
            string clearText = text.Trim();
            if (clearText.Length == 0)
            {
                return false;
            }
            return clearText[clearText.Length - 1] == '?';
        }
        static void Main(string[] args)
        {
            
        }
    }
}
