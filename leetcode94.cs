using System;
using System.Text;

/*
QUESTION: 94. Binary Tree Inorder Traversal

Given the root of a binary tree, return the inorder traversal of its nodes'
values.

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

  public IList<int> InorderTraversal(TreeNode root)
  {
    IList<int> nodeVals = new List<int>();
    void Visit(TreeNode node)
    {
      if (node.left != null) Visit(node.left);
      nodeVals.Add(node.val);
      if (node.right != null) Visit(node.right);
    }
    if (root != null) Visit(root);
    return nodeVals;
  }

  public static void Main()
  {
  }

}
