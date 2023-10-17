public class Program
{
  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
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

  // remove static for leetcode. And change RecursionKillingException to 
  // normal Exception.
  public static bool IsSubPath(ListNode head, TreeNode root) {
    if (head == null || root == null) return false;
    bool subPathFound = false;
    void Visit(ListNode? LLnode, TreeNode? treeNode)
    {
      if (LLnode == null)
      {
        subPathFound = true;
        throw new RecursionKillingException("kill recursion");
      }
      if (treeNode == null) return;
      if (treeNode.val == LLnode.val)
      {
        Visit(LLnode.next, treeNode.left);
        Visit(LLnode.next, treeNode.right);
      }
      else
      {
        if (treeNode.val == head.val)
        {
          Visit(head.next, treeNode.left);
          Visit(head.next, treeNode.right);
        }
        else
        {
          Visit(head, treeNode.left);
          Visit(head, treeNode.right);       
        }
      }
    }
    try 
    {
      Visit(head, root);
    }
    catch (RecursionKillingException) {};
    return subPathFound;
  }

  public static void Main()
  {
  }

}
