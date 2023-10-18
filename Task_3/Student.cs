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
    internal class Student
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public int Age { get; set; }
        public string Univer {  get; set; }

        public Student(string n, string s, int a, string u) 
        {
            Name = n;
            Surname = s;
            Age = a;
            Univer = u;
        }
        public override string ToString()
        {
            return $"Name: {Name}\tSurname: {Surname} \tAge: {Age} \tUnivercity: {Univer}";
        }
    }
}
