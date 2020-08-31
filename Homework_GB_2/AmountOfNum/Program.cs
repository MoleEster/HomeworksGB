using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfNum
{
    class Program
    {   //      Написать метод подсчета количества цифр числа.
        //      Комышан Виктор
        static void Main(string[] args)
        {
            int a = 1111;
            int count = 1;
            while( a > 9)
            {
                a = a / 10;
                count++;
            }
            Console.WriteLine(count);
            Console.Read();

        }
    }
}
