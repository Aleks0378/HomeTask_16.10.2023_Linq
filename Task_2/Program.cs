using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2:
//Для масиву рядків з назвою міст, реалізуйте наступні запити:
// Отримати весь масив міст.
// Отримати міста з довжиною назви, що дорівнює заданому.
// Отримати міста, назви яких починаються з літери A.
// Отримати міста, назви яких закінчуються літерою M.
// Отримати міста, назви яких починаються з літери N і закінчуються літерою K.
// Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням.
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strarr = {"New York", "Mariupol", "Nemirov", "Lviv",
                "Ivano-Franrivsk","Inkerman","Zorinsk", "Zitomir","Energodar",
                "Gaisin","Anthem","Bassum","Coxim", "Enem","Ananiv","Arciz","Alushta",
                "Novoazovsk","Novovolinsk","Novomoskovsk","Novomirgorod","Netishin","Nizin"};

            Console.WriteLine("\n\tОтримати весь масив міст:");
            var quary = from q in strarr
                        select q;
            foreach (var q in quary)
                Console.Write(q + /*$" length: {q.Length}" + */", ");

            Console.WriteLine("\n\n\tОтримати міста з довжиною назви, що дорівнює заданому:");
            Console.Write("Enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            quary = strarr.Where(q => q.Length == length).ToArray();
            foreach (var q in quary)
                Console.Write(q + ", ");

            Console.WriteLine("\n\n\tОтримати міста, назви яких починаються з літери A:");
            quary = from t in strarr
                    where t.ToUpper().StartsWith("A")
                    select t;
            foreach (var q in quary) 
                Console.Write(q+", ");

            Console.WriteLine("\n\n\tОтримати міста, назви яких закінчуються літерою M:");
            quary = strarr.Where(q => q.ToUpper().EndsWith("M"));
            foreach (var q in quary)
                Console.Write(q + ", ");

            Console.WriteLine("\n\n\tОтримати міста, назви яких починаються з літери N і закінчуються літерою K.:");
            quary = strarr.Where(q => q.ToUpper().StartsWith("N") && q.ToUpper().EndsWith("K"));
            foreach (var q in quary)
                Console.Write(q + ", ");

            Console.WriteLine("\n\n\tОтримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням:");
            quary = from t in strarr
                    where t.StartsWith("Ne")
                    orderby t descending
                    select t;
            foreach (var q in quary)
                Console.Write(q + ", ");
            Console.WriteLine("\n");
        }
    }
}
