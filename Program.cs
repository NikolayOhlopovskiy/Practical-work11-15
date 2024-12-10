using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._7
{
    internal class Program
    {
        /// <summary>
        /// Задача 7. Поиск элемента по условию.
        /// </summary>
        /// <param name="args"></param>
       
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            //string first = Array.Find(people, person => person.Length > 3); // Выводит Kate
            //string last =Array.FindLast(people, person => person.Length > 3);//Выводит Alice
            //Console.WriteLine(first);//Выводит Kate
            //Console.WriteLine(last);//Выводит Alice
            //string[] group = Array.FindAll(people, person => person.Length == 3);//Выводит Tom,Sam,Bob,Tom.
            //foreach (var person in group) 
            //Console.WriteLine(person);
            Array.Sort(people, 1,3);
            foreach (var person in people)
                Console.Write($"{person} ");
            Console.Read();
        }
    }
}
