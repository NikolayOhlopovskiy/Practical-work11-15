using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._1
{
    internal class Program
    {
        /// <summary>
        /// Определить количество эллементов в Одномерном массиве.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            int[] omas = new int[] { 1, 2, 3, 10, 5 };
            Console.WriteLine($"Размер:{omas.Length}");
            string[] mas = { "Катя", "Антон", "Никита" };
            int size = mas.Length;
            Console.WriteLine("Размер{size}");
            Console.ReadKey();
        }
    }    
}
