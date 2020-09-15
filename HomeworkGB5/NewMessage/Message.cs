using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMessage
{
     class Message
    {
        public static void NLetters(string[] message, int n)
        {
            Console.Write("Исходная стока: ");
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write($"{message[i]} ");
            }

            Console.Write("\nИскомые слова: ");
            for (int i = 0; i < message.Length; i++)
                if (message[i].Length > n) Console.Write($"{message[i]} ");

        }
        public static void DelNEndings(string[] message, string end)
        {
            for (int i = 0; i < message.Length; i++)
            {
                string word = message[i];
                if (word.Remove(0, word.Length - 1) == end )
                    message[i] = message[i].Remove(0, message[i].Length);
            }
            Console.Write("\nИскомые слова: ");
            for (int j = 0; j < message.Length; j++)
                Console.Write($"{message[j]} ");
        }
        public static string[] MaxLengthWord(string[] message)
        {
            //string[] BigWords = new string[message.Length] ;
            string bigWord = "";
            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (bigWord.Length < message[i].Length || bigWord.Length == message[i].Length)
                {
                    bigWord = message[i];
                    message[j] = bigWord;
                    j++;
                }


            }
            string[] BigWords = new string[j];
            for (int k = 0; k < j; k++)
            {
                BigWords[k] = message[k];
            }
           
            //Random rand = new Random();
            for (int l = 0; l < BigWords.Length; l++)
            {
            Console.WriteLine($"\nСамое длинное слово: {BigWords[l]}");
            }

            //Console.WriteLine($"\nСамое длинное слово: {BigWords[rand.Next(BigWords.Length)]}");
            return BigWords;
        }
        public static void MaxWordsString(string[] message)
        {
            string[] BigWords = MaxLengthWord(message);
            Console.Write("Строка из самых больших слов: ");
            for (int i = 0; i < BigWords.Length; i++)
            {
                Console.Write($"{ BigWords[i]} ");
            }

        }
    }
}
