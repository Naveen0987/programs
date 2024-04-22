using System;

class Program
{
    static void Main(string[] args)
    {
        int[] trades = { 7, 10, 4, 3, 20, 15 };
        HeapSort(trades);
        
        Console.WriteLine("Sorted trades:");
        foreach (var trade in trades)
        {
            Console.Write(trade + " ");
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;

        if (l < n && arr[l] > arr[largest])
            largest = l;

        if (r < n && arr[r] > arr[largest])
            largest = r;

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            Heapify(arr, n, largest);
        }
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }
}
