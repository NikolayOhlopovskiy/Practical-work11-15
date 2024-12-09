using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._2
{
    internal class Program
    {
        /// <summary>
        /// Обнулить заданный диапазон эллементов в Одномерном массиве.
        /// </summary>
        /// <returns></returns>
        static int Size()
        {
            Console.WriteLine("Размер одномерного массива:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0) ;
            Console.WriteLine("Ошибка");
             return size;
        }
        static void Output(int omas)
        {
            //foreach (var el in omas)
            //    Console.WriteLine(el);

        }
        static void Main(string[] args)
        {
            //int[] omas = Input(Size());
            //Array.Clear(omas 1, 3);
            //Output(omas);

        }
    }
}
