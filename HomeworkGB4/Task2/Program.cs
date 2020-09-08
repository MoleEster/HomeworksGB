using System;
using System.IO;

namespace Task2
{
    //     Реализуйте задачу 1 в виде статического класса StaticClass;
    //      а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //      б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //      в)**Добавьте обработку ситуации отсутствия файла на диске.
    //      Комышан Виктор

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0 ;
            int[] array = new int[20];
            Random r = new Random();
            // Заполняем массив
            for (i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10000, 10000);
            }
            // Записываем числа в файл
            SaveToFile("numbers.txt", array);
            // Обработка Ситуации
            try
            {
                StaticClass.Method(i);
            }
            catch
            {
                Console.WriteLine("Файл отсутствует");
            }
            Console.ReadLine();
        }
        private static void SaveToFile(string path,int[] array)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < array.Length ; i++)
            {
                sw.WriteLine(array[i].ToString());
            }
            sw.Close();
        }
    }
    class StaticClass
    {
        public static void Method(int i)
        {
            int counter1 = 0;
            // Считываем числа из файла
            int[] array = GetFromFile("numbers.txt");
            // Проверяем выполнение условий и увеличиваем счетчик при правильности выполнения
            for (i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0 || array[i] % 3 != 0 && array[i + 1] % 3 == 0)
                {
                    counter1++;
                }
            }
            // Вывод
            for (i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(counter1);
            Console.ReadLine();
        }
        private static int[] GetFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            int[] arr = new int[20];
            int i = 0;
            while (!sr.EndOfStream)
            {
                arr[i] = Convert.ToInt32(sr.ReadLine());
                i++;
            }
            sr.Close();
            return arr;           
        }
    }
}
