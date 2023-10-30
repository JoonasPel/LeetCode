using System;

/*
QUESTION: 203. Remove Linked List Elements

Given the head of a linked list and an integer val, remove all the nodes of
the linked list that has Node.val == val, and return the new head.

APPROACH:
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
  public static ListNode? RemoveElements(ListNode? head, int val)
  {
    if (head == null) return head;
    ListNode? current = head.next;
    ListNode? prev = head;
    while (current != null)
    {
      if (current.val == val)
      {
        prev.next = current.next;
      }
      else
      {
        prev = current;
      }
      current = current.next;
    }
    return head.val == val ? head.next : head;
  }


  public static void Main()
  {
  }

}
