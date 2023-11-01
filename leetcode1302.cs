using System;
using System.Text;

/*
QUESTION: 1302. Deepest Leaves Sum

Given the root of a binary tree, return the sum of values of its deepest leaves

APPROACH:
Go through the tree recursively and count the sum of the deepest nodes SO FAR.
If even deeper nodes are found, replace the sum and start summing again nodes
that are in the same level.
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

  // remove static for leetcode
  public static int DeepestLeavesSum(TreeNode root)
  {
    if (root == null) return 0;

    int deepestLevelSoFar = 0;
    int tempSum = 0;
    void Visit(TreeNode? node, int level)
    {
      if (level > deepestLevelSoFar)
      {
        deepestLevelSoFar = level;
        tempSum = node.val;
      }
      else if (level == deepestLevelSoFar)
      {
        tempSum += node.val;
      }
      level++;
      if (node.left != null) Visit(node.left, level);
      if (node.right != null) Visit(node.right, level);
    }

    Visit(root, 0);
    return tempSum;
  }

  public static void Main()
  {
  }

}
