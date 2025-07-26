/**
 * https://leetcode.com/problems/add-two-numbers/submissions/1712148556
 */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var firstNode = new ListNode();

        var current = firstNode;

        var sum = 0;
        var carry = 0;

        while (l1 != null || l2 != null || carry != 0){
            var x = l1?.val ?? 0;
            var y = l2?.val ?? 0;
            
            sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10, null);

            l1 = l1?.next;
            l2 = l2?.next;
            current = current.next;
        }

        return firstNode.next;
    }
}
