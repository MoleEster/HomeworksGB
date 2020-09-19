using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_GB_2
{
    // Написать метод, возвращающий минимальное из трех чисел.
    // Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 2;
            Minimal(a, b, c);
        }

        private static void Minimal(int a, int b, int c)
        {
            if (a < b && a < c) Console.WriteLine($"{a}  - минимальное");
            else if (c < b && c < a) Console.WriteLine($"{c}  - минимальное");
            else Console.WriteLine($"{b}  - минимальное");
        }
    }
}
