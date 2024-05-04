using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayBasic
{
    /// <summary>
    /// Given two sorted arrays, arr1, and arr2 of size n and m. Find the union of two sorted arrays.
    ///The union of two arrays can be defined as the common and distinct elements in the two arrays.NOTE: Elements in the union should be in ascending order.
    /// </summary>
    public class UnionOfSortedArrays
    {
        public static void Run(int[] arr1, int[] arr2)
        {
            Printer.PrintInput(arr1);
            Printer.PrintInput(arr2);

            List<int> arr = new();

            //TWO POINTER:
            int i =0, j = 0;
            int n = arr1.Length, m = arr2.Length;
            while (i < n || j < m)
            {
                if (i == n)
                {
                    if (arr.Count == 0 || arr[^1] != arr2[j])
                    {
                        arr.Add(arr2[j]);
                    }
                    j++;
                }
                else if (j == m)
                {
                    if (arr.Count == 0 || arr[^1] != arr1[i])
                    {
                        arr.Add(arr1[i]);
                    }
                    i++;
                }
                else if (arr1[i] <= arr2[j])
                {

                    if (arr.Count ==0 || arr[^1] != arr1[i])
                    {
                        arr.Add(arr1[i]);
                    }
                    i++;
                }
                else
                {
                    if (arr.Count == 0 || arr[^1] != arr2[j])
                    {
                        arr.Add(arr2[j]);
                    }
                    j++;
                }
            }
            

            int[] ans = arr.ToArray();
            Printer.PrintOutput(ans);

        }
    }
}
