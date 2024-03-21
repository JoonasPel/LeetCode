/*
DIFFICULTY: Easy
QUESTION: 160. Intersection of Two Linked Lists

Given the heads of two singly linked-lists headA and headB, return the node at
which the two lists intersect. If the two linked lists have no intersection at
all, return null.

INTUITION/APPROACH:
Put both LL nodes into their own Stacks. Then Pop the stacks one-by-one and
find the first node that is not common, the node before that is the intersect.
*/

using Utilities;

public class Solution
{
  public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
  {
    Stack<ListNode> nodesA = new();
    Stack<ListNode> nodesB = new();
    ListNode nodeA = headA;
    ListNode nodeB = headB;
    while (nodeA != null)
    {
      nodesA.Push(nodeA);
      nodeA = nodeA.next;
    }
    while (nodeB != null)
    {
      nodesB.Push(nodeB);
      nodeB = nodeB.next;
    }
    ListNode? commonNode = null;
    while (nodesA.Count > 0 && nodesB.Count > 0)
    {
      nodeA = nodesA.Pop();
      nodeB = nodesB.Pop();
      if (ReferenceEquals(nodeA, nodeB))
      {
        commonNode = nodeA;
      }
      else
      {
        break;
      }
    }
    return commonNode;
  }

  public static void Main()
  {
  }
}
