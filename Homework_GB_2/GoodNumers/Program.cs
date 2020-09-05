using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumers
{   //      Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число,
    //      которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    //      Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int number = 1; number < 100000; number++)
            {
                int summa = 0;
                Podschet(number,ref summa);
                if (number % summa == 0)
                {
                    j++;
                }
            }
            Console.WriteLine(j);
            Console.ReadLine();
        }

        private static int Podschet(int number,ref int summa)
        {
            do
            {
                if (number > 9)
                {
                    summa += number % 10;
                    number = number / 10;
                }
                else
                {
                    summa += number;
                    break;
                }

            } while (true);
            return summa;
        }
    }
}
