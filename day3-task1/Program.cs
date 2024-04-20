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

    public static void InsertElement(int[] array, int index, int element)
    {
        if (index < 0 || index > array.Length)
        {
            throw new IndexOutOfRangeException("Index out of bounds");  
        }

        int[] newArray = new int[array.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        newArray[index] = element;

        for (int i = index + 1; i < newArray.Length; i++)
        {
            newArray[i] = array[i - 1];
        }

        array = newArray;
    }

    public static void DeleteElement(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }

        int[] newArray = new int[array.Length - 1]; 

        for (int i = 0; i < index; i++) 
        {
            newArray[i] = array[i];
        }

        for (int i = index; i < newArray.Length; i++) 
        {
            newArray[i] = array[i + 1];
        }

        array = newArray;
    }

    public static void UpdateElement(int[] array, int index, int element)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }

        array[index] = element;
    }

    public static void ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = ArrayManipulator.InitializeArray(10);
        Console.WriteLine("Original Array: " + string.Join(",", myArray));

        ArrayManipulator.InsertElement(myArray, 3, 50);
        Console.WriteLine("Array after Insert(3, 50): " + string.Join(",", myArray));

        ArrayManipulator.DeleteElement(myArray, 1);
        Console.WriteLine("Array after Delete(1): " + string.Join(",", myArray));

        ArrayManipulator.UpdateElement(myArray, 5, 100);
        Console.WriteLine("Array after Update(5, 100): " + string.Join(",", myArray));
    }
}
