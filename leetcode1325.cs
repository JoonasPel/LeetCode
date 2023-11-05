using System;
using System.Text;

/*
QUESTION: 1325. Delete Leaves With a Given Value

Given a binary tree root and an integer target, delete all the leaf nodes with
value target.

Note that once you delete a leaf node with value target, if its parent node
becomes a leaf node and has the value target, it should also be deleted
(you need to continue doing that until you cannot).

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

  public TreeNode? RemoveLeafNodes(TreeNode root, int target)
  {
    bool Visit(TreeNode node)
    {
      if (node == null) return false;
      bool leftIsLeaf = Visit(node.left);
      if (leftIsLeaf && node.left.val == target)
      {
        node.left = null;
      }
      bool rightIsLeaf = Visit(node.right);
      if (rightIsLeaf && node.right.val == target)
      {
        node.right = null;
      }
      return node.left == null && node.right == null;
    }

    Visit(root);
    // check root too if it became a leaf.
    if (root.left == null && root.right == null && root.val == target)
    {
      root = null;
    }
    return root;
  }

  public static void Main()
  {
  }

}
