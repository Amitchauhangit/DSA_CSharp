using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Printer
    {
        public static void PrintInput<T>(T[] arr)
        {
            Console.WriteLine("Input array: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        public static void PrintOutput<T>(T[] arr)
        {
            Console.WriteLine("Output array: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
