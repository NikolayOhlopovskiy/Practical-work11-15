using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._8
{
    internal class Program
    {
        /// <summary>
        /// Задача 8. Изменение размера массива.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            
            Array.Resize(ref people, 4);

            foreach (var person in people)
                Console.Write($"{person} ");
            Console.Read();
        }
    }
}
