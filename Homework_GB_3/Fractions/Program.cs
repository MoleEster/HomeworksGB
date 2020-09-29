using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{//     *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
 //      Предусмотреть методы сложения, вычитания, умножения и деления дробей.
 //      Написать программу, демонстрирующую все разработанные элементы класса.
 //      Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            Fraction z1 = new Fraction(1, 5);
            Fraction z2 = new Fraction(3, 4);
            Console.WriteLine($"Первое число: {z1}");
            Console.WriteLine($"Второе число: {z2}\n");
            if (z1.denum != 0)
            {
                Fraction z3 = z1 + z2;
                Fraction z4 = z1 - z2;
                Fraction z5 = z1 * z2;
                Fraction z6 = z1 / z2;
                Console.WriteLine($"Сумма: {z3}");
                Console.WriteLine($"Разность: {z4}");
                Console.WriteLine($"Произведение: {z5}");
                Console.WriteLine($"Частное: {z6}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Знаменатель не может быть равен нулю!");
                Console.ReadLine();
            }
            
        }
    }
}
