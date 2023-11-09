using System;

/*
DIFFICULTY: Medium
QUESTION: 382. Linked List Random Node

Given a singly linked list, return a random node's value from the linked list.
Each node must have the same probability of being chosen.

Implement the Solution class:

    Solution(ListNode head) Initializes the object with the head of the
    singly-linked list head.
    int getRandom() Chooses a node randomly from the list and returns its
    value. All the nodes of the list should be equally likely to be chosen.

APPROACH:
Just make a list and get random value from there with Random.Next ?
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


  public class Solution
  {
    private IList<int> values = new List<int>();
    private int valuesCount = 0;
    Random rand = new Random();

    public Solution(ListNode head)
    {
      ListNode current = head;
      while (current != null)
      {
        values.Add(current.val);
        valuesCount++;
        current = current.next;
      }
    }

    public int GetRandom()
    {
      return values[rand.Next(0, valuesCount)];
    }
  }

  public static void Main()
  {
  }
}
