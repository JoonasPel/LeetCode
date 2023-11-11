using System;

/*
DIFFICULTY: Medium
QUESTION: 725. Split Linked List in Parts

Given the head of a singly linked list and an integer k, split the
linked list into k consecutive linked list parts.

The length of each part should be as equal as possible:
no two parts should have a size differing by more than one.
This may lead to some parts being null.

The parts should be in the order of occurrence in the input list,
and parts occurring earlier should always have a size
greater than or equal to parts occurring later.

Return an array of the k parts.

APPROACH:
Count the node amount, then get the dividend and remainder when 
the linked list is split to k parts. loop through the nodes and
"cut" = set node.next to null in parts where split is made.
Splitted parts have atleast a size of total nodes / k and
+1 if there is remainder left to be given.
for example splitting 11 nodes when k=3 makes the part sizes:
4(3+1), 4(3+1), 3
because the remainder is 2.
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

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public static ListNode[] SplitListToParts(ListNode head, int k)
  {
    int count = 0;
    ListNode current = head;
    while (current != null)
    {
      count++;
      current = current.next;
    }
    int even = count / k;
    int remainder = count % k;
    ListNode[] parts = new ListNode[k];

    current = head;
    int i = 0;
    int partsIndex = 0;
    ListNode tempNext = null;
    while (current != null)
    {
      if (i == 0) parts[partsIndex] = current;
      i++;
      tempNext = current.next;
      if (i == (even + (remainder > 0 ? 1 : 0)))
      {
        current.next = null;
        partsIndex++;
        i = 0;
        remainder--;
      }
      current = tempNext;
    }
    return parts;
  }

  public static void Main()
  {

  }
}
