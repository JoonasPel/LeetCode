using System;
using System.Numerics;
using System.Text;

/*
QUESTION: 2807. Insert Greatest Common Divisors in Linked List

Given the head of a linked list head, in which each node contains an integer
value.

Between every pair of adjacent nodes, insert a new node with a value equal to
the greatest common divisor of them.

Return the linked list after insertion.

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

  public ListNode InsertGreatestCommonDivisors(ListNode head)
  {
    int greatestCommonDivisor = 0;
    void Visit(ListNode node, ListNode? prev)
    {
      if (prev != null)
      {
        greatestCommonDivisor =
          (int)BigInteger.GreatestCommonDivisor(prev.val, node.val);
        prev.next = new ListNode(greatestCommonDivisor, node);
      }
      if (node.next != null) Visit(node.next, node);
    }
    if (head != null) Visit(head, null);
    return head;
  }

  public static void Main()
  {
  }

}
