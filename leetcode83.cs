using System;

/*
DIFFICULTY: Easy
QUESTION: 83. Remove Duplicates from Sorted List
Given the head of a sorted linked list, delete all duplicates such
that each element appears only once. Return the linked list sorted
as well.

APPROACH:
*/

public class Program
{

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }

  public ListNode DeleteDuplicates(ListNode head)
  {
    if (head == null) return head;
    ListNode current = head;
    ListNode prev = head;
    while (current != null)
    {
      if (prev != null && prev.val != current.val)
      {
        prev.next = current;
        prev = current;
      }
      current = current.next;
    }
    prev.next = null;
    return head;
  }

  public static void Main()
  {
  }
}
