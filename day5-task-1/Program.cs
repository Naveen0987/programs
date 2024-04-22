using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class CustomLinkedList
{
    private Node head;

    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node lastNode = head;
        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }
        lastNode.Next = newNode;
    }

    public void InsertAtPosition(int data, int position)
    {
        if (position < 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 0)
        {
            InsertAtBeginning(data);
            return;
        }

        Node newNode = new Node(data);
        Node prevNode = null;
        Node currentNode = head;
        int currentPosition = 0;

        while (currentPosition < position && currentNode != null)
        {
            prevNode = currentNode;
            currentNode = currentNode.Next;
            currentPosition++;
        }

        if (currentNode == null)
        {
            Console.WriteLine("Position out of bounds");
            return;
        }

        newNode.Next = currentNode;
        prevNode.Next = newNode;
    }

    public void DeleteNode(int data)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node prevNode = null;
        Node currentNode = head;

        while (currentNode != null && currentNode.Data != data)
        {
            prevNode = currentNode;
            currentNode = currentNode.Next;
        }

        if (currentNode == null)
        {
            Console.WriteLine("Node not found");
            return;
        }

        prevNode.Next = currentNode.Next;
    }

    public void UpdateNode(int oldData, int newData)
    {
        Node currentNode = head;

        while (currentNode != null && currentNode.Data != oldData)
        {
            currentNode = currentNode.Next;
        }

        if (currentNode == null)
        {
            Console.WriteLine("Node not found");
            return;
        }

        currentNode.Data = newData;
    }

    public void DisplayAllNodes()
    {
        Node currentNode = head;

        while (currentNode != null)
        {
            Console.Write(currentNode.Data + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomLinkedList linkedList = new CustomLinkedList();

        linkedList.InsertAtEnd(10);
        linkedList.InsertAtEnd(20);
        linkedList.InsertAtEnd(30);
        linkedList.InsertAtBeginning(5);

        linkedList.DisplayAllNodes();

        linkedList.InsertAtPosition(15, 2);
        linkedList.DisplayAllNodes();

        linkedList.UpdateNode(15, 25);
        linkedList.DisplayAllNodes();

        linkedList.DeleteNode(20);
        linkedList.DisplayAllNodes();
    }
}
