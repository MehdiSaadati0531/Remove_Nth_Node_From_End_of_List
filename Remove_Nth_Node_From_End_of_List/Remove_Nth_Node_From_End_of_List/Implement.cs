namespace MergeTwoSortedLists
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
    public class Solution
    {
        public int Puzzle(ListNode head)
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                return 1 + Puzzle(head.next);
            }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = Puzzle(head);
            int nodeValue = length - n;
            int counter = nodeValue;
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                var tempNode = head;
                if (nodeValue == 0)
                {
                    head = head.next;
                    return head;
                }
                while (counter > 1)
                {
                    tempNode = tempNode.next;
                    counter--;
                }

                tempNode.next = tempNode.next.next;
            }

            return head;
        }
    }
}
