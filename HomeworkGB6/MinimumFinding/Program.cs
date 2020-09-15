using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumFinding
{
    class Program
    {
        delegate double function(double x, double a);
        static double func(double x,double a)
        {
            return x * x * a;
        }
        static double func1(double x, double a)
        {
            return 1.0/x + x * a *a;
        }
        static double func2(double x, double a)
        {
            return Math.Sin(x) * 1.0/a;
        }
        static double Minimum(List<function> functions, int start, int end,double a, int method )
        { 
            double minimum = 10000000000;
               
                for (int x = start; x < end; x++)
                {
                    if(functions[method - 1](x,a) < minimum)
                    {
                        minimum = functions[method - 1](x, a);
                    }

                } 
            return minimum;

        }

        static void Main(string[] args)
        {

            List<function> methods = new List<function>() {func,func1,func2};
            Console.WriteLine("Выберите Функцию: \n1)x^2 * a\n2)1/x + x * a^2\n3)Sin(x) * 1/a\nНомер функции: ");
            int method = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите точку отсчета");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите конечную точку");
            int end  = int.Parse(Console.ReadLine());;

            Console.WriteLine($"Введите перменную a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Минимум функции: {Minimum(methods, start, end, a, method)}");
            Console.ReadLine();
        }
    }
}
