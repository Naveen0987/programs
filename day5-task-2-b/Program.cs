using System;

public class CustomQueue
{
    private object[] queueArray;
    private int front;
    private int rear;
    private int maxSize;

    public CustomQueue(int size)
    {
        maxSize = size;
        queueArray = new object[maxSize];
        front = 0;
        rear = -1;
    }

    public void Enqueue(object item)
    {
        if (rear == maxSize - 1)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }
        queueArray[++rear] = item;
    }

    public object Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow");
            return null;
        }
        object item = queueArray[front++];
        return item;
    }

    public object Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        return queueArray[front];
    }

    public bool IsEmpty()
    {
        return front > rear;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomQueue queue = new CustomQueue(5);

        queue.Enqueue("Hello");
        queue.Enqueue(10);
        queue.Enqueue("World");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}
