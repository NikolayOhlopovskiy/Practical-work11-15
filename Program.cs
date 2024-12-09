using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._3
{
    internal class Program
    {
        /// <summary>
        /// Найти max и min значения в Одномерном массиве.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = new int[] { 3, -7, 4, 11, -9, -3 };
            int max=omas.Max();
            int min = omas.Min();
            Console.WriteLine($"Максимальное:{max}\tМинимальное:{min}");

        }
    }
}
