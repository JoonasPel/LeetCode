using System;
using System.Text;

/*
QUESTION: 1448. Count Good Nodes in Binary Tree

Given a binary tree root, a node X in the tree is named good if in the path
from root to X there are no nodes with a value greater than X.

Return the number of good nodes in the binary tree.

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

  public int GoodNodes(TreeNode root)
  {
    int goodNodes = 0;
    void Visit(TreeNode node, int greatestSoFar = int.MinValue)
    {
      if (node.val >= greatestSoFar)
      {
        goodNodes++;
      }
      greatestSoFar = Math.Max(node.val, greatestSoFar);
      if (node.left != null) Visit(node.left, greatestSoFar);
      if (node.right != null) Visit(node.right, greatestSoFar);
    }
    if (root != null) Visit(root);
    return goodNodes;
  }

  public static void Main()
  {
  }

}
