using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorise
{   //     Реализовать метод проверки логина и пароля.
    //     На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //     Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //     С помощью цикла do while ограничить ввод пароля тремя попытками.
    //     Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            string login = "root";
            string password = "GeekBrains";
            int i = 0;
            bool Enter = false;
            do
            {
                Console.WriteLine("Введите логин:");
                string log = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string pass = Console.ReadLine();
                if (log == login && pass == password)
                {
                    Enter = true;
                }
                else
                {
                    i++;
                    Console.Clear();
                    Console.WriteLine($"Неверные данные, повторите попытку\nОсталось попыток {3 - i}");
                }

            } while (i != 3 && Enter != true);

            if (i==3)
            {
                Console.WriteLine("Количество попыток закончилось");
            }
            else Console.WriteLine($"Добро пожаловать, {login}");
            Console.ReadLine();
        }
    }
}
