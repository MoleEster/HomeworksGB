using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeworkGB5
{
    class Program
    {
        //      Создать программу, которая будет проверять корректность ввода логина.
        //      Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //      а) без использования регулярных выражений;
        //      б) **с использованием регулярных выражений.
        //      Комышан Виктор
        static void Main(string[] args)
        {   //A
            /*Console.WriteLine("Введите логин( логин должен быть от 2 до 10 символов, содержать только буквы латинского алфавита или цифры, при этом цифра не может быть первой): ");
            string login = $"{Console.ReadLine()}";
            bool res = true;
            for (int i = 1; i < login.Length; i++)
            {
                if (login.Length <= 2 || login.Length >= 10 || char.IsDigit(login[0]) || (!(login[i] >= 'a' && login[i] <= 'z') && !char.IsDigit(login[i])))
                    res = false;

            }
            if (res == false)
                Console.WriteLine("Логин не может содержать цифру в начале и должен состоять из букв латиницы");
            else Console.WriteLine($"Добро пожаловать, {login}");*/


            // Б
            Regex myReg = new Regex(@"[A-Za-z]{1}[A-Za-z0-9]{1,9}");
            Console.WriteLine("Введите логин( логин должен быть от 2 до 10 символов, содержать только буквы латинского алфавита или цифры, при этом цифра не может быть первой): ");
            string login = Console.ReadLine();
            if (myReg.IsMatch(login) && !Char.IsDigit(login[0])) Console.WriteLine($"Добро пожаловать, {login}"); 
            else Console.WriteLine("Логин не может содержать цифру в начале и должен состоять из букв латиницы");
            Console.ReadLine();
           
        }
    }
}
