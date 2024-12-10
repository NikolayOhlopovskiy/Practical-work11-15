using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._10
{
    internal class Program
    {
        /// <summary>
        /// Задача 10. Удаление всех четных элементов из массива, и в новом массиве сложить эллементы.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] arr = {3,7,1,9,5,6,8,10};
            arr=arr.Where(x=>x%2!=0).ToArray();
            foreach(int i in arr) 
                Console.WriteLine(i);
            int sum=arr.Sum();
            Console.Write(sum);
            Console.Read();
        }
    }
}
