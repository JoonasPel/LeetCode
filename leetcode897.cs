using System;
using System.Text;

/*
QUESTION: 897. Increasing Order Search Tree

Given the root of a binary search tree, rearrange the tree in in-order so
that the leftmost node in the tree is now the root of the tree, and every node
has no left child and only one right child.

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

  // remove static for leetcode
  public static TreeNode IncreasingBST(TreeNode root)
  {
    if (root == null) return root;

    TreeNode pseudoRoot = new TreeNode(0);
    TreeNode current = pseudoRoot;
    void Visit(TreeNode node)
    {
      if (node.left != null) Visit(node.left);
      current.right = node;
      current = current.right;
      node.left = null;
      if (node.right != null) Visit(node.right);
    }

    Visit(root);
    return pseudoRoot.right;
  }

  public static void Main()
  {
  }

}
