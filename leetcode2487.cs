/*
DIFFICULTY: Medium
QUESTION: 2487. Remove Nodes From Linked List

You are given the head of a linked list.

Remove every node which has a node with a greater value anywhere to the right
side of it.

Return the head of the modified linked list.

INTUITION/APPROACH:
The better solution "RemoveNodes" uses Stack to go to the end of the LL and
then return while keeping count of the largest value and basically jumping over
nodes with too small value.
*/

using Utilities;

public class Solution
{
  public ListNode RemoveNodes(ListNode head)
  {
    Stack<ListNode> stack = new();
    ListNode current = head;
    while (current != null)
    {
      stack.Push(current);
      current = current.next;
    }
    ListNode earlier = stack.Pop();
    int maxVal = earlier.val;
    while (stack.Count > 0)
    {
      current = stack.Pop();
      if (current.val >= maxVal)
      {
        maxVal = Math.Max(maxVal, current.val);
        current.next = earlier;
        earlier = current;
      }
      else
      {
        current.next = null;
      }
    }
    return earlier;
  }


  // This recursive approach is simply too slow for arrays of length 100k etc.
  // And this approach also hits stack overflow that I am trying to counter
  // by doing multiple "cycles" i.e. going deep and stopping and returning
  // before stack overflow is hit. Then going again deeper with some nodes removed.
  public ListNode RemoveNodesDEAD(ListNode head)
  {
    if (head == null) return null;
    int callStackCount = 0;
    bool callStackCountHit = true;
    while (callStackCountHit)
    {
      head = Visit(head).nextNode;
    }
    return head;

    (int maxVal, ListNode nextNode) Visit(ListNode node)
    {
      if (++callStackCount > 40000)
      {
        callStackCountHit = true;
        callStackCount = 0;
        return (node.val, node);
      }
      if (node.next != null)
      {
        (int maxValRight, ListNode nextNode) = Visit(node.next);
        node.next = nextNode;
        if (maxValRight > node.val)
        {
          return (maxValRight, nextNode);
        }
        else
        {
          return (Math.Max(maxValRight, node.val), node);
        }
      }
      else
      {
        callStackCountHit = false;
        return (node.val, node);
      }
    }
  }

  public static void Main()
  {
    Solution app = new();
    ListNode head = LinkedListUtils.ArrayToLinkedList([1, 20, 5, 2, 1, 0, 13, 3, 8, 15]);
    LinkedListUtils.PrintLinkedList(head);
    ListNode result = app.RemoveNodesDEAD(head);
    LinkedListUtils.PrintLinkedList(result);
  }
}
