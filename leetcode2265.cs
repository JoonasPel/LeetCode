using System;
using System.Text;

/*
QUESTION: 2265. Count Nodes Equal to Average of Subtree

Given the root of a binary tree, return the number of nodes where the value of
the node is equal to the average of the values in its subtree.

Note:

    The average of n elements is the sum of the n elements divided by n and
    rounded down to the nearest integer.
    A subtree of root is a tree consisting of root and all of its descendants.

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

  public int AverageOfSubtree(TreeNode root)
  {
    int validNodes = 0;
    int tempSum, tempCount;

    (int nodesSum, int nodesCount) Visit(TreeNode node)
    {
      if (node == null) return (0, 0);
      if (node.left == null && node.right == null)
      {
        validNodes++; //leaf is always valid
        return (node.val, 1);
      }
      (int nodesSumLeft, int nodesCountLeft) = Visit(node.left);
      (int nodesSumRight, int nodesCountRight) = Visit(node.right);
      tempSum = node.val + nodesSumLeft + nodesSumRight;
      tempCount = 1 + nodesCountLeft + nodesCountRight;
      if (node.val == tempSum / tempCount)
      {
        validNodes++;
      }
      return (tempSum, tempCount);
    }

    if (root != null) Visit(root);
    return validNodes;
  }

  public static void Main()
  {
  }

}
