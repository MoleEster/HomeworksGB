using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public int Course { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Student(int age, int course, string name)
        {
            this.Age = age;
            this.Course = course;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name,7} Age: {Age,3} Course: {Course,2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 40;
            List<Student> list = new List<Student>();
            string[] names = new string[] { "Вася", "Коля", "Петя", "Маша", "Даша", "Катя", "Леша", "Дима", "Стелла" };
            Random rnd = new Random();
            for (int i = 0; i < numberOfStudents; i++)
            {
                list.Add(
                    new Student(age: rnd.Next(18, 27),
                                course: rnd.Next(1, 7),
                                name: names[rnd.Next(names.Length)]));

            }
            Console.WriteLine($"{ CountStudents(list,numberOfStudents)}");
            list.Sort(SortCourseAge);
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }

        // Сортировка по курсу и возрасту(достаточно сомнительно получилось, возможно ввиду того, что некоторые студенты в возрасте 19 находятся на 6 курсе...)
        private static int SortCourseAge(Student x, Student y)
        {
            return x.Age < y.Age && x.Course < y.Course ? -1 : 1;
        }
        // Сортировка по возрасту
        private static int SortStudentsAge(Student x, Student y)
        {
            return x.Age < y.Age? -1:1 ;
        }

        public static int CountStudents(List<Student> list, int numberOfStudnets)
        {
            int counter = 0;
            for (int i = 0; i < numberOfStudnets; i++)
            {
            if (list[i].Course == 5 || list[i].Course == 6)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
