using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
//        Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//        а) используя склеивание;
//        б) используя форматированный вывод;
//        в) используя вывод со знаком $.
//        Комышан Виктор


        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес");
            int weight = Convert.ToInt32(Console.ReadLine());
            double I = weight / (height * height);
            // Вывод а
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            // Вывод б
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);
            // Вывод в
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight} ");
            Console.Read();
        }
    }
}
