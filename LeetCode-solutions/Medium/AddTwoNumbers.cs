namespace LeetCode_solutions.Medium
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int reminder = 0;
            var result = new ListNode();
            var current = result;
            while (l1 != null || l2 != null)
            {
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;

                var sum = x + y + reminder;
                reminder = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
            
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            
                if(l1 == null && l2 == null && reminder > 0){
                    current.next = new ListNode(reminder);
                }
            }

            return result.next;
        }
    }
    
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
}