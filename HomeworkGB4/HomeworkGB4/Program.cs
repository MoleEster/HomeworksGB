﻿using System;

namespace HomeworkGB4
{//         Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
 //         Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
 //         В данной задаче под парой подразумевается два подряд идущих элемента массива.
 //         Комышан Викор
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int counter1 = 0;
            int[] array = new int[20];
            Random r = new Random();
            for(i = 0; i<array.Length ;i++)
            {
                array[i] = r.Next(-10000, 10000);
            }
            for (i =0; i<array.Length - 1;i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0 || array[i] % 3 != 0 && array[i + 1] % 3 == 0)
                {
                    counter1++;
                }
            }
            for(i=0;i<array.Length;i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(counter1);
            Console.ReadLine();

        }
    }
}
