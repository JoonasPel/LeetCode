/*
DIFFICULTY: Easy
QUESTION: 145. Binary Tree Postorder Traversal

DESCRIPTION:
Given the root of a binary tree, return the postorder traversal of
its nodes' values.

INTUITION/APPROACH:
Recursively visit left subtree first, then right subtree, then handle
the node itself too.
*/

using Utilities;

public class Solution
{

  public IList<int> PostorderTraversalRECURSIVE(TreeNode root)
  {
    IList<int> result = new List<int>();
    if (root != null) Visit(root);
    return result;

    void Visit(TreeNode node)
    {
      if (node.left != null) Visit(node.left);
      if (node.right != null) Visit(node.right);
      result.Add(node.val);
    }
  }

  public static void Main()
  {
  }
}
