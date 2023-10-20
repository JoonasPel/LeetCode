using System;

public class Program
{
  public class ListNode
  {
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
      this.val = val;
      this.next = next;
    }
  }

  public static ListNode? ArrayToLinkedList(int[] vals)
  {
    int index = vals.Length - 1;
    ListNode? next = null;
    while (index >= 0)
    {
      ListNode newNode = new ListNode(vals[index], next);
      next = newNode;
      index--;
    }
    return next;
  }

  public static void PrintLinkedList(ListNode? head)
  {
    ListNode? current = head;
    while (current != null)
    {
      Console.Write($"{current?.val} -> ");
      current = current.next;
    }
    Console.WriteLine("null");
  }

  /* APPROACH:
    Recursively go to the end of the linked list and start coming back while
    counting the nodes and when arriving to the Nth node, remove it by making
    its prev node connect to its next node. and its own next to null.
  */
  // remove static for leetcode.
  public static ListNode RemoveNthFromEnd(ListNode head, int n)
  {
    (ListNode?, int) Visit(ListNode? node)
    {
      if (node == null) return (null, 0);

      (ListNode? next, int counter) = Visit(node.next);
      if (++counter == n) // we are at the node that is removed.
      {
        return (node, counter);
      }
      else if (next != null) // remove node and connect earlier to the new next
      {
        node.next = next.next;
        next.next = null;
      }
      return (null, counter);
    }

    (ListNode? node, int counter) = Visit(head);
    if (node != null)  // takes care of removing the 1st node (head) if needed
    {
      head = head.next;
    }
    return head;
  }

  public static void Main()
  {
    int[] vals = { 1, 2, 3, 4, 5 };
    ListNode? head = ArrayToLinkedList(vals);
    PrintLinkedList(head);
    ListNode? resultHead = RemoveNthFromEnd(head, 4);
    PrintLinkedList(resultHead);
  }

}
