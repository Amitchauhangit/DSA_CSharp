using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayBasic
{
    /// <summary>
    /// Given two sorted arrays, arr1, and arr2 of size n and m. Find the union of two sorted arrays.
    ///The Intersection of two arrays can be defined as the common and distinct elements in the two arrays.NOTE: Elements in the union should be in ascending order.
    /// </summary>
    public class IntersectionOfSortedArrays
    {
        public static void Run(int[] arr1, int[] arr2)
        {
            Printer.PrintInput(arr1);
            Printer.PrintInput(arr2);

            List<int> arr = new();
            Array.Sort(arr1);
            Array.Sort(arr2);

            //TWO POINTER:
            int i =0, j = 0;
            int n = arr1.Length, m = arr2.Length;
            
            while (i < n || j < m)
            {
                if (arr1[i] == arr2[j])
                {
                    arr.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }
            

            int[] ans = arr.ToArray();
            Printer.PrintOutput(ans);

        }
    }
}
