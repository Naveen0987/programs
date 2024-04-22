using System;
using System.Collections.Generic;

public class Program
{
    public static bool IsSequencePresent(Stack<int> stack, int[] sequence)
    {
        int sequenceIndex = 0;

        while (stack.Count > 0)
        {
            if (stack.Pop() == sequence[sequenceIndex])
            {
                sequenceIndex++;
                if (sequenceIndex == sequence.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(2);
        stack.Push(5);
        stack.Push(7);
        stack.Push(1);

        int[] sequence = { 5, 7 };

        Console.WriteLine("Sequence present: " + IsSequencePresent(stack, sequence)); // Output: True
    }
}
