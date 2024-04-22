using System;

public class CustomStack
{
    private int[] stackArray;
    private int top;
    private int maxSize;

    public CustomStack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1;
    }

    public void Push(int item)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        stackArray[++top] = item;
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        return stackArray[top--];
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        return stackArray[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomStack stack = new CustomStack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
