using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Array.Reverse(array);
            Console.WriteLine("Реверсированный массив: " + string.Join(", ", array));
            Console.Read();

        }
    }
}
