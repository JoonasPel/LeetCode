using System;

/*
QUESTION: 2181. Merge Nodes in Between Zeros

You are given the head of a linked list, which contains a series of integers
separated by 0's. The beginning and end of the linked list will have
Node.val == 0.

For every two consecutive 0's, merge all the nodes lying in between them into
a single node whose value is the sum of all the merged nodes.
The modified list should not contain any 0's.

Return the head of the modified linked list.

APPROACH:
*/

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

  public ListNode MergeNodes(ListNode head)
  {
    ListNode prevZero = null;
    ListNode current = head;
    int tempSum = 0;
    while (current != null)
    {
      if (current.val != 0) tempSum += current.val;
      else
      {
        current.val = tempSum;
        tempSum = 0;
        if (prevZero != null) prevZero.next = current;
        prevZero = current;
      }
      current = current.next;
    }
    return head.next; // head is the first zero so we dont want to include it
  }

  public static void Main()
  {
  }
}
