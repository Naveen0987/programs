using System;

public class ArrayOperations
{
    public static int SumArray(int[] arr, int index)
    {
        if (index >= arr.Length)
        {
            return 0;
        }
        else
        {
            return arr[index] + SumArray(arr, index + 1);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] exampleArray = { 1, 2, 3, 4, 5 };
        int sum = ArrayOperations.SumArray(exampleArray, 0);
        Console.WriteLine("Sum of the array: " + sum);
    }
}
