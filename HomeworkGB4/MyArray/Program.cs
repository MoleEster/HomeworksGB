using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{//     а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
 //     Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
 //     метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
 //     Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(5, 5, 5);
            Console.WriteLine($"\n{ a.Sum}");


            foreach (var item in a.Inverse)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            Console.WriteLine(Convert.ToInt32(a.ToString()));
            Console.WriteLine();


            foreach (var item in a.Multi)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(a.MaxCount);
            Console.Read();
        }
    }
    class MyArray
    {
        int[] a;
        public MyArray(int n, int StartPoint, int increase)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = StartPoint + increase * i;
                Console.Write($"{a[i]} ");
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public int[] Inverse
        {
            get
            { int[] b = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i] * -1;
                }
                return b;
            }
        }
        public int[] Multi
        {

            get
            {
                int[] c = a;
                int n = 2;
                for (int i = 0; i < a.Length; i++)
                {
                    c[i] = c[i] * n;
                }
                return c;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = 0;
                int count = 0;
                for(int i = 0; i<a.Length;i++)
                {
                    if(max<a[i])
                    {
                        max = a[i];
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (max == a[i])
                        count++;
                }
                return count;
            }
        }

    }
}
