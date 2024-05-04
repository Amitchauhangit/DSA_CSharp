using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    /// <summary>
    /// Given an array of N integers, left rotate the array by K place
    /// </summary>
    public class LeftRotateByK_Place
    {
        public static void Run(int[] arr,int k)
        {
            Console.WriteLine("Input array: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();

            //Optimal T-> O(2N), S-> O(1)
            Array.Reverse(arr,0,k);
            Array.Reverse(arr,k,arr.Length-k);
            Array.Reverse(arr);

            Console.WriteLine("Final Array: ");
            //Array.Resize(ref arr,i+1);
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
            
        }
    }
}
