using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGB7
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 0.02;
            double counter = 0;
            for (int i = 1; i <= 9; i++)
            {
                if(i>3)
                {
                    counter += i * x;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
