using System;

/*
QUESTION: 1290. Convert Binary Number in a Linked List to Integer

Given head which is a reference node to a singly-linked list. The value of
each node in the linked list is either 0 or 1. The linked list holds the
binary representation of a number.

Return the decimal value of the number in the linked list.

The most significant bit is at the head of the linked list.

APPROACH:
Go to the end recursively and return while calculating the decimal
*/

public class Program
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

  // remove static for leetcode
  public static int GetDecimalValue(ListNode head)
  {
    if (head == null) return 0;

    (double number, int counter) Visit(ListNode node)
    {
      if (node.next == null) return (node.val, 0);
      var (number, counter) = Visit(node.next);
      counter++;
      return (number + node.val * Math.Pow(2, counter), counter);
    }

    return (int)Visit(head).number;
  }


  public static void Main()
  {
  }

}
