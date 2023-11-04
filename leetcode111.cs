using System;
using System.Text;

/*
QUESTION: 111. Minimum Depth of Binary Tree

Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from
the root node down to the nearest leaf node.

Note: A leaf is a node with no children.

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

  public int MinDepth(TreeNode root)
  {
    if (root == null) return 0;
    int minimumSoFar = int.MaxValue;
    void Visit(TreeNode node, int level)
    {
      level++;
      if (node.left == null && node.right == null)
      {
        minimumSoFar = Math.Min(minimumSoFar, level);
        return;
      }
      if (node.left != null) Visit(node.left, level);
      if (node.right != null) Visit(node.right, level);
    }
    Visit(root, 0);
    return minimumSoFar;
  }

  public static void Main()
  {
  }

}
