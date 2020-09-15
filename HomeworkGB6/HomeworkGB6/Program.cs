using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGB6
{
    class Program
    {
        delegate double function(double h, double a);
        static double f(double x,double a )
        {
            return x * x * a;
        }
        static double g(double x, double a)
        {
            return 1.0/a * Math.Sin(x);
        }
        static double h(double x, double a)
        {
            return a * 2 + a * Math.Cos(x);
        }



        static void Plot(List<function> f,  int start, int end)
        {
            for (int i = 0; i < f.Count; i++)
            {
                Console.WriteLine($"Функция №{i + 1}");
                for (int x = start; x <= end; x++)
                {
                    Console.WriteLine($"f({x,2}) = {f[i](x,a: 5),2}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            List<function> methods = new List<function>() {f};
            methods.Add(g);
            methods.Add(h);
            Plot(methods, -6, 5);
            Console.ReadLine();

        }
    }
}
