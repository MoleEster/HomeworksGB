using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacement
{
    class Program
    {
        // Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        // Комышан Виктор
        static void Main(string[] args)
        {
            int counter = 0;
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            for (int i = 0; i < word2.Length; i++)
            {
                for (int j = 0; j < word1.Length; j++)
                {
                    if (word1[i] == word2[j]) counter++;
                }

            }
            if (counter == word1.Length) Console.WriteLine("Перестановка");

            Console.ReadLine();
        }
    }
}
