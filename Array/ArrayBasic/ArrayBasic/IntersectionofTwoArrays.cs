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
    /// Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must be unique and you may return the result in any order.
    /// </summary>
    public class IntersectionOfTwoArrays
    {
        public static void Run(int[] arr1, int[] arr2)
        {
            Printer.PrintInput(arr1);
            Printer.PrintInput(arr2);

            List<int> arr = new();

            //TWO POINTER:
            int i = 0, j = 0;
            int n = arr1.Length, m = arr2.Length;
            Array.Sort(arr1);
            Array.Sort(arr2);
            int ii = arr1.Sum();

            while (i < n && j < m)
            {
                if (arr1[i] == arr2[j])
                {
                    if (arr.Count == 0 || arr[^1] != arr1[i])
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
