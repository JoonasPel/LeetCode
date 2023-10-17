public class Program
{
  public class RecursionKillingException : Exception
  {
    public RecursionKillingException()
    {
    }
    public RecursionKillingException(string message)
      : base(message)
    {
    }
  }

  public class ListNode
  {
    public int val;
    public ListNode? next;
    public ListNode(int val, ListNode? next=null)
    {
      this.val = val;
      this.next = next;
    }
  }

  public static ListNode? ArrayToLinkedList(int[] vals)
  {
    int index = vals.Length-1;
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

  /** APPROACH:
  Go to the end of linked list and return recursively while 
  returning the next node starting from head. like this:
  1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null. STOP RECURSION
  --------  4 <- 3 <- 2 <- head(1)
  And do ListNode.next swaps also. Calculate linked list length to know when
  to stop returning and kill the recursion with handled expection.
  **/

  // remove static for leetcode. and use Exception instead of RecursionKilling
  public static void ReorderList(ListNode head)
  {
    if (head == null) return;
    int ListLength = 0;

    (ListNode?, int swapCount) Visit(ListNode? node, ListNode? head)
    {
      ListLength++;
      if (node.next != null) 
      {
        (ListNode next, int swapCount) = Visit(node.next, head);
        swapCount++;
        if (swapCount > Math.Floor((double)ListLength / 2))
        {
          next.next = null;
          throw new RecursionKillingException("kill recursion");
        }
        ListNode newNext = next.next;
        node.next = next.next;
        next.next = node;
        return (newNext, swapCount);
      }
      else
      {
        ListNode next = head.next;
        head.next = node;
        node.next = next;
        return (next, 1);
      }
    }

    try
    {
      Visit(head, head);
    }
    catch (RecursionKillingException) {}
  }

  public static void Main()
  {
    int[] vals = {1,2,3,4,5,6,7,8,9,10,11};
    ListNode? head = ArrayToLinkedList(vals);
    PrintLinkedList(head);
    ReorderList(head);
    PrintLinkedList(head);
  }

}
