public class ListNode {
    public int value;
    public ListNode next;
    
    public ListNode(int value = 0, ListNode next = null) {
        this.value = value;
        this.next = next;
    }
}

public class Program {
    public static ListNode RemoveDuplicates(ListNode head) {
        ListNode current = head;
        
        while (current != null && current.next != null) {
            if (current.value == current.next.value) {
                current.next = current.next.next;
            } else {
                current = current.next;
            }
        }
        
        return head;
    }

    static void Main(string[] args) {
        ListNode head = new ListNode(1);
        head.next = new ListNode(1);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(2);
        head.next.next.next.next = new ListNode(3);

        ListNode result = RemoveDuplicates(head);

        while (result != null) {
            Console.WriteLine(result.value);
            result = result.next;
        }
    }
}
