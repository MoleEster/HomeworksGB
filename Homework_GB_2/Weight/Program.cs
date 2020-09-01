using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight
{
    class Program
    {   //      а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
        //      нужно ли человеку похудеть, набрать вес или все в норме; 
        //      б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        //      Комышан Виктор
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш рост(в метрах): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = (weight) / Math.Pow(height , 2);
            double NormWeight;
            if (imt < 18.5)
            {
                NormWeight = (18.5 * Math.Pow(height , 2));
                Console.WriteLine($"Ваш вес ниже нормы\nДля нормализации веса вам нужно набрать {NormWeight - weight}");
            }
            else if (imt >= 25)
            {
                NormWeight = (25 * Math.Pow(height, 2));
                Console.WriteLine($"Ваш вес выше нормы\nДля нормализации веса вам нужно скинуть {weight - NormWeight}");
            }
            else Console.WriteLine("Ваш вес в норме");
            Console.ReadLine();
        }
    }
}
