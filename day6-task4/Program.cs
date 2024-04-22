using System;
using System.Collections.Generic;

public class Program
{
    public static void SortStack(Stack<int> stack)
    {
        Stack<int> tempStack = new Stack<int>();

        while (stack.Count > 0)
        {
            int temp = stack.Pop();

            while (tempStack.Count > 0 && tempStack.Peek() > temp)
            {
                stack.Push(tempStack.Pop());
            }

            tempStack.Push(temp);
        }

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);
        stack.Push(1);
        stack.Push(3);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
