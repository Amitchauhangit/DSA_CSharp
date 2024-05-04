using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{

    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
    /// </summary>
    public class RemoveDuplicatesFromSortedArray
    {
        //BruteForce
        // Use Set; put all elements in set (distinct ele), then traverse set and put set's ele back in Arr and update remaining with Default(T)

        //optimal -> 2 pointer  
        public static void Run(int[] arr)
        {

            Console.WriteLine("Input array: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
            
            int i = 0;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[++i] = arr[j];
                }
            }

            Console.WriteLine("Final Array: ");
            Array.Resize(ref arr,i+1);
            foreach (var item in arr)
                Console.Write($"{item} ");

            Console.WriteLine($"\nTotal Unique Elements: {arr.Length}");
            Console.WriteLine();
        }
    }
}
