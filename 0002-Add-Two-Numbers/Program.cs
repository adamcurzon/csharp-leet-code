public class Program
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode head = result;
        int sum = 0;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;

            Console.WriteLine($"{val1}, {val2}, {carry}");

            sum = val1 + val2 + carry;

            carry = sum / 10;

            head.next = new ListNode(sum % 10);
            head = head.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        return result.next;
    }

    static void Main()
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));


        ListNode r = AddTwoNumbers(l1, l2);
        while (r != null)
        {
            Console.WriteLine(r.val);
            r = r.next;
        }
        // Console.WriteLine(23 % 10);
    }
}

