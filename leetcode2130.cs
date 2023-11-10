using System;

/*
DIFFICULTY: Medium
QUESTION: 2130. Maximum Twin Sum of a Linked List

In a linked list of size n, where n is even, the ith node (0-indexed)
of the linked list is known as the twin of the (n-1-i)th node, if
0 <= i <= (n / 2) - 1.

    For example, if n = 4, then node 0 is the twin of node 3,
    and node 1 is the twin of node 2. These are the only nodes with
    twins for n = 4.

The twin sum is defined as the sum of a node and its twin.

Given the head of a linked list with even length, return the maximum
twin sum of the linked list.

APPROACH:
Go to end recursively and bring list head there. then start
returning head.next so we have twin nodes in same recursion calls.
Now we can just find the biggest sum of twin nodes by tracking the
biggest so far with a variable.
head (1) -> 2 -> 3 -> 4 -> null
      4  <- 3 <- 2 <- 1  <- return head
Non-recursive way would probably be faster because it allowed
the implementation of an early stop if biggest possible was already
found. Biggest possible = biggest single node value * 2.
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

  public int PairSum(ListNode head)
  {
    int largestSumSoFar = int.MinValue;
    ListNode Visit(ListNode node)
    {
      if (node == null) return head;
      ListNode twinNode = Visit(node.next);
      largestSumSoFar = Math.Max(largestSumSoFar, twinNode.val + node.val);
      return twinNode.next;
    }
    if (head != null) Visit(head);
    return largestSumSoFar;
  }
  public static void Main()
  {
  }
}
