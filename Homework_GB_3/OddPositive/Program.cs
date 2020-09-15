using System;

namespace OddPositive
{
    class Program
    {   //      а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
        //      Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        //      б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        //      При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
        //      Комышан Виктор
        static void Main(string[] args)
        {
            double res = 1;
            double numeral = 0;
            string numerals = "";
            while (res != 0 )
            {
                Console.WriteLine("Введите число: ");
                var check = double.TryParse(Console.ReadLine(),out res);
                if (res % 2 == 1 && res > 0)
                {
                    numeral += res;
                    numerals += $"{res} ";
                }
                else if (check == false)
                {
                    Console.WriteLine("Введены некорретные данные");
                    res = 2;
                }
            }
            Console.WriteLine($"Сумма: {numeral}\nЧисла: {numerals}");
        }
    }
}
