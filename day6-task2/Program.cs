﻿using System;

public class ListNode
{
    public int value;
    public ListNode next;
    
    public ListNode(int value = 0, ListNode next = null)
    {
        this.value = value;
        this.next = next;
    }
}

public class Program
{
    public static int FindMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow.value;
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        Console.WriteLine("Middle element: " + FindMiddle(head)); 
    }
}
