using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{//     Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
 //     Комышан Виктор
    class Program
    {
        static void Main(string[] args)
        {
            bool Access = false;
            string[] array = new string[] { "Login", "password" };
            SaveToFile("account.txt", array);
            Account user = new Account();


            Console.WriteLine("Введите логин: ");
            string userlogin = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите пароль: ");
            string userpassword = Convert.ToString(Console.ReadLine());


            if (userlogin == user.Login && userpassword == user.Password) Access = true;
            if (Access == true) Console.WriteLine($"Добро пожаловать, {userlogin}");
            else Console.WriteLine("Попробуйте еще раз");


            Console.ReadLine();
        }
        private static void SaveToFile(string path, string[] array)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i].ToString());
            }
            sw.Close();
        }
        private static string[] GetFromFile(string path, int spot)
        {
            StreamReader sr = new StreamReader(path);
            string[] arr = new string[spot];
            int i = 0;
            while (!sr.EndOfStream)
            {
                arr[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
            return arr;
        }
        class Account
        {
            string [] array = GetFromFile("account.txt", 2);
            public string Login
            {
                get
                {
                    string login = array[0];
                    return login;
                }
            }
            public string Password
            {
                get
                {
                    string password = array[1];
                    return password;
                }
            }
        }
    }
}
