using System;

public class ArrayOperations
{
    public static int[] SliceArray(int[] arr, int start, int end)
    {
        int length = end - start + 1;
        int[] slicedArray = new int[length];
        Array.Copy(arr, start, slicedArray, 0, length);
        return slicedArray;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] slicedArray = ArrayOperations.SliceArray(originalArray, 2, 6);
        Console.WriteLine("Sliced Array:");
        foreach (int num in slicedArray)
        {
            Console.WriteLine(num);
        }
    }
}
