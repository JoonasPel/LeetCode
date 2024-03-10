using Utilities;
/*
DIFFICULTY: Medium
QUESTION: 701. Insert into a Binary Search Tree

You are given the root node of a binary search tree (BST) and a value to insert
into the tree. Return the root node of the BST after the insertion. It is
guaranteed that the new value does not exist in the original BST.

Notice that there may exist multiple valid ways for the insertion, as long as
the tree remains a BST after insertion. You can return any of them.

INTUITION/APPROACH:
Visit the tree nodes and give the param of the next node as ref so when we
find the spot for target value, we can directly add it there.
*/

public class Solution
{
  public class RecursionKillingException : Exception
  {
    public RecursionKillingException(string message)
      : base(message)
    {
    }
  }

  public TreeNode InsertIntoBST(TreeNode root, int val)
  {
    try
    {
      Visit(ref root);
    }
    catch (RecursionKillingException) { }
    return root;

    void Visit(ref TreeNode node)
    {
      if (node == null)
      {
        node = new TreeNode(val);
        throw new RecursionKillingException("Kill recursion");
      }
      else if (node.val < val)
        Visit(ref node.right);
      else
        Visit(ref node.left);
    }
  }
}
