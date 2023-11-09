using System;

/*
DIFFICULTY: Medium
QUESTION: 1721. Swapping Nodes in a Linked List

You are given the head of a linked list, and an integer k.

Return the head of the linked list after swapping the values of the kth node
from the beginning and the kth node from the end (the list is 1-indexed).

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

  public ListNode SwapNodes(ListNode head, int k)
  {
    ListNode firstNode = null;
    ListNode secondNode = null;
    int nodeCounter = 0; // 1 indexed

    int Visit(ListNode node)
    {
      if (node == null) return 0;
      nodeCounter++;
      if (nodeCounter == k)
      {
        firstNode = node;
      }
      int index = Visit(node.next) + 1;
      if (index == k)
      {
        secondNode = node;
        throw new Exception("kill recursion");  // should use custom exception
      }
      return index;
    }

    try
    {
      Visit(head);
    }
    catch (Exception) { }
    (firstNode.val, secondNode.val) = (secondNode.val, firstNode.val);
    return head;
  }

  public static void Main()
  {
  }
}
