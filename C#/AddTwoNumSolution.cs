//29/05/2022
//https://leetcode.com/problems/add-two-numbers/

//Question
//Input: l1 = [2,4,3], l2 = [5,6,4]
//Output: [7,0,8]
//Explanation: 342 + 465 = 807.

//Runtime: 123 ms, faster than 50.80% of C# online submissions for Add Two Numbers.
//Memory Usage: 39.2 MB, less than 85.21% of C# online submissions for Add Two Numbers.
//Time complexity : O(\max(m, n))O(max(m,n)). Assume that mm and nn represents the length of l1l1 and l2l2 respectively, the algorithm above iterates at most \max(m, n)max(m,n) times.
//Space complexity : O(\max(m, n))O(max(m,n)). The length of the new list is at most \max(m,n) + 1max(m,n)+1.

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

    public class AddTwoNumSolution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode dummy = new ListNode();
            ListNode tmp1 = l1, tmp2 = l2, current = dummy;
            int overflow = 0;
            while(tmp1 != null || tmp2 != null){
                int x = (tmp1 != null)?tmp1.val:0;
                int y = (tmp2 != null)?tmp2.val:0;
                int sum = x + y + overflow;
                overflow = sum/10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if(tmp1 != null) tmp1 = tmp1.next;
                if(tmp2 != null) tmp2 = tmp2.next;
            }
            
            if(overflow > 0)
                current.next = new ListNode(overflow);
            
            return dummy.next;
        }
    }