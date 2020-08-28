using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_GB_1
{
    class Program
    {
 //        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 //        б) *Сделать задание, только вывод организовать в центре экрана.
 //        в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
 //        Комышан Виктор
        static void Print(string info)
        {
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.WindowHeight / 2);
                Console.WriteLine(info);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введте имя: ");
            string name = Console.ReadLine();
            Console.Write("Введте фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введте город проживания: ");
            string city = Console.ReadLine();
            // Вывод в центре экрана
            int x = Console.WindowHeight;
            int y = Console.WindowWidth;
            string info = $"{name} {surname} {city}";
            Print(info);
            while (true)
            {
                if (x != Console.WindowHeight || y != Console.WindowWidth)
                {
                    x = Console.WindowHeight;
                    y = Console.WindowWidth;
                    Print(info);
                }
            }
        }
    }
}
