using System;

/// <summary>
/// Given an array, find the second smallest and second largest element in the array. Print ‘-1’ in the event that either of them doesn’t exist.
/// </summary>

public class FindSecondLargestElementInArray
{
    //Optimal ->  T -> O(N)
    public static void Run(int[]  arr)
    {
        int n = arr.Length;
        int largest = Int32.MinValue;
        int slargest = Int32.MinValue;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                slargest = largest;
                largest = arr[i];
            }else if (arr[i] < largest && arr[i] > slargest)
            {
                slargest = arr[i];
            }
        }

        Console.WriteLine("Printing input array: ");
        foreach (var i in arr)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();

        Console.WriteLine($"Second Largest: {slargest}");

    }

}
