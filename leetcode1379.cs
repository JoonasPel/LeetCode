using System;
using System.Text;

/*
QUESTION: 1379. Find a Corresponding Node of a Binary Tree in a Clone of That
Tree

Given two binary trees original and cloned and given a reference to a node
target in the original tree.

The cloned tree is a copy of the original tree.

Return a reference to the same node in the cloned tree.

Note that you are not allowed to change any of the two trees or the target node
and the answer must be a reference to a node in the cloned tree.

APPROACH:
Just go through the cloned tree and find a node that has same value as target.
When found, throw exception to kill recursion.
*/

public class Program
{

  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public TreeNode GetTargetCopy(
    TreeNode original,
    TreeNode cloned,
    TreeNode target)
  {

    TreeNode result = new TreeNode(0);
    void Visit(TreeNode? node)
    {
      if (node == null) return;
      if (node.val == target.val)
      {
        result = node;
        throw new Exception();  // should use custom exception instead of this
      }
      if (node.left != null) Visit(node.left);
      if (node.right != null) Visit(node.right);
    }

    try
    {
      Visit(cloned);
    }
    catch (Exception) { }
    return result;
  }

  public static void Main()
  {
  }

}
