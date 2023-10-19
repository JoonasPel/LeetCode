using System;

public class Program
{
  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
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

  /* APPROACH:
    Recursively go through tree and check that every node value is equal to 
    root value, if one wrong value found, kill recursion and return false.
  */
  // remove static for leetcode. and use Exception instead of RecursionKilling
  public static bool IsUnivalTree(TreeNode root)
  {
    if (root == null) return true;
    int unival = root.val;
    bool wrongValueFound = false;

    void Visit(TreeNode? node)
    {
      if (node == null) return;
      if (node.val != unival)
      {
        wrongValueFound = true;
        throw new RecursionKillingException("kill recursion");
      }
      Visit(node.left);
      Visit(node.right);
    }

    try
    {
      Visit(root);
    }
    catch (RecursionKillingException) { }
    return !wrongValueFound;  // no wrong value found = is valid unival tree
  }

  public static void Main()
  {
  }
}
