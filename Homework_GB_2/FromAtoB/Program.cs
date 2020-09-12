using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAtoB
{   //       a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)
    //       б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    //       Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 15;
            int summa = 0;
            Counter(a, b,ref summa);
            Console.WriteLine("\nСумма всех чисел: " + summa);
            Console.ReadLine();
        }
        private static int Counter(int a, int b,ref int summa)
        {
            if (a != b - 1)
            {
                a++;
                summa += a;
                Console.Write(a + " ");
                Counter(a, b,ref summa);
            }
            return summa;

        }
    }
}
