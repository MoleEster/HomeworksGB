using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Change
{
    class Program
    {
//        Написать программу обмена значениями двух переменных:
//          а) с использованием третьей переменной;
//          б) *без использования третьей переменной.
//          Комышан Виктор

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первой переменной");
            double FirstVariable = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второй переменной");
            double SecondVariable = Convert.ToDouble(Console.ReadLine());


            // C использованием третьей переменной 


            //double Changing = FirstVariable;
            //FirstVariable = SecondVariable;
            //SecondVariable = Changing;


            // Без использования третьей перменной
            if (FirstVariable > SecondVariable)
            {
                FirstVariable = FirstVariable - SecondVariable;
                SecondVariable = FirstVariable + SecondVariable;
                FirstVariable = SecondVariable - FirstVariable;
            }
            else
            {
                SecondVariable = SecondVariable - FirstVariable;
                FirstVariable = SecondVariable + FirstVariable;
                SecondVariable = FirstVariable - SecondVariable;
            }

            Console.WriteLine($"Первая переменная = {FirstVariable} \nВторая переменная = {SecondVariable}");
            Console.ReadLine();
        }
    }
}
