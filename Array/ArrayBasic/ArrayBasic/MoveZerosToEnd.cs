using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    /// <summary>
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// </summary>
    public class MoveZerosToEnd
    {
        public static void Run(int[] arr)
        {
            Console.WriteLine("Input array: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
            int N = arr.Length;
            int i = 0, j = - 1;

            for (; i < N; i++)
            {
                if (arr[i] == 0)
                {
                    j = i; break;
                }
            }

            if (j == -1)
                return;//return arr;

            for (i = j + 1; i < N; i++)
            {
                if (arr[i] != 0)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    j++;
                }
            }

            Console.WriteLine("Final Array: ");
            //Array.Resize(ref arr,i+1);
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
            
        }
    }
}
