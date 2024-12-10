using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._6
{
    internal class Program
    {
        /// <summary>
        /// Задача 6. Подсчет количества вхождений определенного числа в массив.
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 1, 9, 5, 3, 6, 3 };
            int count = 0;
            int mas = array.Count
                 (x => x == 3);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
