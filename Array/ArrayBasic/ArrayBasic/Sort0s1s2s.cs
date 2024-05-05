using System;
using System.Runtime.Intrinsics.X86;
namespace ArrayBasic
{
    /// <summary>
    /// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
    ///We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.You must solve this problem without using the library's sort function.
    /// </summary>
    internal class Sort0s1s2s
    {
        public static void Run(int[] arr)
        {
            Printer.PrintInput(arr);

            int n=arr.Length;
            int low=0,mid=0,high=n-1;

            while (mid <= high )
            {
                if (arr[mid]==0)
                {
                    Swap(arr, low,mid);
                    low++;
                    mid++;
                }
                else if (arr[mid]==1) {
                    mid++;
                }else
                {
                    Swap(arr, mid, high);
                    high--;
                }
            }

            Printer.PrintOutput(arr);

        }

        private static void Swap(int[] arr, int i, int j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}
