using System;

/*
DIFFICULTY: Easy
QUESTION: 876. Middle of the Linked List

Given the head of a singly linked list, return the middle node of the
linked list.

If there are two middle nodes, return the second middle node.

APPROACH:
Recursively go to end and calculate node count. Then come back and find middle
*/

namespace Joonas
{

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

    public ListNode MiddleNode(ListNode head)
    {
      ListNode? middleNode = null;
      int nodeCount = 0;
      int goalIndex = -1;
      int Visit(ListNode node)
      {
        if (node == null)
        {
          goalIndex = (nodeCount - 1) / 2;
          return -1;
        }
        nodeCount++;
        int index = Visit(node.next) + 1;
        if (index == goalIndex)
        {
          middleNode = node;
          throw new Exception("kill recursion");  //should use custom exception
        }
        return index;
      }

      try
      {
        Visit(head);
      }
      catch (Exception) { }
      return middleNode;
    }

    public static void Main()
    {
    }
  }

}
