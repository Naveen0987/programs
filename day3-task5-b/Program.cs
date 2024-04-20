using System;

public class Fibonacci
{
    public static int[] GenerateFibonacci(int n)
    {
        int[] fibonacciArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            fibonacciArray[i] = CalculateFibonacci(i);
        }
        return fibonacciArray;
    }

    private static int CalculateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = 10; 
        int[] fibonacciSequence = Fibonacci.GenerateFibonacci(n);

        Console.WriteLine("Fibonacci Sequence:");
        foreach (int num in fibonacciSequence)
        {
            Console.WriteLine(num);
        }
    }
}
