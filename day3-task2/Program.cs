using System;

public class ArrayManipulator
{
    public static int[] InitializeArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 101);
        }
        return array;
    }

    public static void BruteForceSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) 
        {
            int smallestIndex = i; 
            for (int j = i + 1; j < array.Length; j++) 
            {
                if (array[j] < array[smallestIndex]) 
                {
                    smallestIndex = j; 
                }
            }

            if (i != smallestIndex) 
            {
                int temp = array[i]; 
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }
        }
    }

    public static int PerformLinearSearch(int[] array, int element)
    {
        
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] == element) 
            {
                return i; 
            }
        }
        return -1; 
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = ArrayManipulator.InitializeArray(10);
        Console.WriteLine("Original Array: " + string.Join(",", myArray)); 

        ArrayManipulator.BruteForceSort(myArray);

        Console.WriteLine("Sorted Array: " + string.Join(",", myArray)); 

        int elementToFind = 50;
        int elementIndex = ArrayManipulator.PerformLinearSearch(myArray, elementToFind);

        if (elementIndex != -1)
        {
            Console.WriteLine("Element " + elementToFind + " found at index: " + elementIndex);
        }
        else
        {
            Console.WriteLine("Element " + elementToFind + " not found in the array.");
        }
    }
}
