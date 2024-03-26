/*
DIFFICULTY: Medium
QUESTION: 814. Binary Tree Pruning

Given the root of a binary tree, return the same tree where every subtree
(of the given tree) not containing a 1 has been removed.

A subtree of a node node is node plus every node that is a descendant of node.

INTUITION/APPROACH:
Recursively visit every node and return the sum of subtrees vals + node's val.
If a node receives zero from its subtree, remove that subtree (make it null)
*/

using Utilities;

public class Solution
{
  public TreeNode PruneTree(TreeNode root)
  {
    if (root == null) return null;
    return Visit(root) == 0 ? null : root;

    int Visit(TreeNode node)
    {
      if (node.left == null && node.right == null)
      {
        return node.val;
      }
      int totalSum = 0;
      if (node.left != null)
      {
        if (Visit(node.left) == 0) node.left = null;
        else totalSum++;
      }
      if (node.right != null)
      {
        if (Visit(node.right) == 0) node.right = null;
        else totalSum++;
      }
      return totalSum + node.val;
    }
  }

  public static void Main()
  {
  }
}
