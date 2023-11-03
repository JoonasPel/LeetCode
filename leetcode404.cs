using System;
using System.Text;

/*
QUESTION: 404. Sum of Left Leaves

Given the root of a binary tree, return the sum of all left leaves.

A leaf is a node with no children. A left leaf is a leaf that is the
left child of another node.

APPROACH:
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

  public int SumOfLeftLeaves(TreeNode root)
  {
    int tempSum = 0;
    void Visit(TreeNode node, bool isLeftNode)
    {
      if (node.left == null && node.right == null)
      {
        if (isLeftNode) tempSum += node.val;
        return;
      }
      if (node.left != null) Visit(node.left, true);
      if (node.right != null) Visit(node.right, false);
    }
    if (root != null) Visit(root, false);
    return tempSum;
  }

  public static void Main()
  {
  }

}
