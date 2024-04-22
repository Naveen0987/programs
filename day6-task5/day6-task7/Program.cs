public class ListNode {
    public int value;
    public ListNode next;
    
    public ListNode(int value = 0, ListNode next = null) {
        this.value = value;
        this.next = next;
    }
}

public class Program {
    public static ListNode MergeLists(ListNode head1, ListNode head2) {
        if (head1 == null) return head2;
        if (head2 == null) return head1;
        
        if (head1.value < head2.value) {
            head1.next = MergeLists(head1.next, head2);
            return head1;
        } else {
            head2.next = MergeLists(head1, head2.next);
            return head2;
        }
    }

    static void Main(string[] args) {
        ListNode head1 = new ListNode(1);
        head1.next = new ListNode(3);
        head1.next.next = new ListNode(5);

        ListNode head2 = new ListNode(2);
        head2.next = new ListNode(4);
        head2.next.next = new ListNode(6);

        ListNode mergedHead = MergeLists(head1, head2);

        while (mergedHead != null) {
            Console.WriteLine(mergedHead.value);
            mergedHead = mergedHead.next;
        }
    }
}
