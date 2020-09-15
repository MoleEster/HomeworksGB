using System;

namespace HomeworkGB2
{//      а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры
 //      б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 //      Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(1, 2);
            Console.WriteLine(z1);

            Complex z2 = new Complex(2, 3);
            Console.WriteLine(z2);

            Complex z3 = z1 + z2;
            Complex z4 = z1 * z2;

            Console.WriteLine(z3);
            Console.WriteLine(z4);

        }
    }
}
