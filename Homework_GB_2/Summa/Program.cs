using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa
{
    //      С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
    //      Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int count = 0;
            while (a != 0 )
            {
                Console.Write("Введите число:");
                a =Convert.ToInt32(Console.ReadLine());
                if (a%2 == 1 && a > 0)
                {
                    count =count + a;
                }
            }
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
