using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 328. Odd Even Linked List

Given the head of a singly linked list, group all the nodes with odd indices
together followed by the nodes with even indices, and return the reordered list

The first node is considered odd, and the second node is even, and so on.

Note that the relative order inside both the even and odd groups should remain
as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time
complexity.

APPROACH:
Go through the linked list and make every node point to the .next.next node.
At the end, connect the last odd node to the first even node.
*/


public class Solution
{
  public class ListNode
  {
    public int val;
    public ListNode? next;
    public ListNode(int val, ListNode? next = null)
    {
      this.val = val;
      this.next = next;
    }
  }

  public ListNode OddEvenList(ListNode head)
  {
    if (head == null) return head;
    ListNode current = head;
    ListNode firstEven = head.next;
    ListNode lastOdd = null;
    ListNode? tempNext;
    bool odd = true;
    while (true)
    {
      if (odd) lastOdd = current;
      tempNext = current.next;
      if (tempNext == null) break;
      if (current.next.next != null)
      {
        current.next = current.next.next;
      }
      else
      {
        current.next = null;
      }
      current = tempNext;
      odd = !odd;
    }
    lastOdd.next = firstEven;
    return head;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
