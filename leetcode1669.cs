using System;

/*
DIFFICULTY: Medium
QUESTION: 1669. Merge In Between Linked Lists

You are given two linked lists: list1 and list2 of sizes n and m
respectively.

Remove list1's nodes from the ath node to the bth node,
and put list2 in their place.

The blue edges and nodes in the following figure indicate the result:

APPROACH:
Go to end of list2 and save its end. Then go through list1 and find
node a-1(index) and make its .next list2head, then keep going and find
node b+1(index) and make list2 last node point to it. then stop loop.
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

  public ListNode MergeInBetween(
    ListNode list1, int a, int b, ListNode list2)
  {
    // get list2 last node
    ListNode current = list2;
    ListNode list2End = null;
    while (current != null)
    {
      if (current.next == null)
      {
        list2End = current;
      }
      current = current.next;
    }
    // insert list2 between list1 nodes a-1 and b+1. (a,b are indexes)
    current = list1;
    int nodeIndex = 0;
    ListNode next = null;
    while (true)
    {
      next = current.next;
      if (nodeIndex == a - 1)
      {
        current.next = list2;
      }
      else if (nodeIndex == b + 1)
      {
        list2End.next = current;
        break;
      }
      current = next;
      nodeIndex++;
    }

    return list1;
  }

  public static void Main()
  {
  }
}
