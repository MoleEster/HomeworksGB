using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGE_Task4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while (N < 10 || N > 100)
            {
                Console.Write("Введите количество учеников: ");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(N);
            Console.ReadLine();
        }
    }
}
