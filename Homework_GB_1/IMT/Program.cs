using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class Program
    {
//          Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
//          Комышан Виктор

        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес");
            int weight = Convert.ToInt32(Console.ReadLine());
            double I = weight / (height * height);
            Console.WriteLine($"ИМТ:{I}");
            Console.ReadLine();
        }
    }
}
