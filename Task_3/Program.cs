using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3:
//Реалізуйте тип користувача «Студент» з інформацією про ім'я, прізвище, вік, назву навчального закладу.
//Для масиву «Студент» реалізуйте наступні запити:
// Отримати весь масив студентів.
// Отримати список студентів з ім'ям Boris.
// Отримати список студентів з прізвищем, яке починається з Bro.
// Отримати список студентів, старших 19 років.
// Отримати список студентів, старших 20 років і молодших 23 років.
// Отримати список студентів, які навчаються в MIT.
// Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням.
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Oleg", "Budarov", 25, "ONAC"),
                new Student("Boris", "Ivanov", 20, "ONMU"),
                new Student("Sergii", "Stupka", 21, "MIT"),
                new Student("Urii", "Brother", 26, "ONUM"),
                new Student("Valerii", "Brokunov", 22, "Oxford"),
                new Student("Dmitrii", "Efremov", 18, "Oxford"),
                new Student("Evgenii", "Soldatov", 23, "MIT"),
                new Student("Boris", "Prikol", 24, "MIT"),
                new Student("Boris", "Brovarskii", 19, "ONAN"),
                new Student("Oleksandr", "Prohanii", 25, "KDMA"),
                new Student("Valentin", "Figarov", 28, "LNDA"),
                new Student("Oleg", "Yablukov", 19, "Oxford"),
                new Student("Vasilii", "Zheleznii", 21, "Oxford"),
                new Student("Petr", "Evtyhovich", 26, "Oxford")};

            Console.WriteLine("\n\tОтримати весь масив студентів:");
            var quary = students.Select(s => s);
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів з ім'ям Boris:");
            quary = students.Where(s => s.Name=="Boris");
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів з прізвищем, яке починається з Bro:");
            quary = students.Where(s => s.Surname.StartsWith("Bro"));
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів, старших 19 років:");
            quary = students.Where(s => s.Age>19);
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів, старших 20 років і молодших 23 років.:");
            quary = students.Where(s => s.Age > 20 && s.Age<23);
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів, які навчаються в MIT:");
            quary = students.Where(s => s.Univer == "MIT");
            foreach (var student in quary)
                Console.WriteLine(student);

            Console.WriteLine("\n\tОтримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням:");
            quary = students.Where(s => s.Univer == "Oxford" && s.Age>18).OrderByDescending(s=>s.Age);
            foreach (var student in quary)
                Console.WriteLine(student);

        }
    }
}
