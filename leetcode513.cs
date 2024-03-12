/*
DIFFICULTY: Medium
QUESTION: 513. Find Bottom Left Tree Value

Given the root of a binary tree, return the leftmost value in the last row of
the tree.

INTUITION/APPROACH:
Travel the tree by always going left subtree first. Keep count of the lowest
level found so far and update the value of the bottom left node if deeper
node is found. Other same level nodes do not "override" the value.
*/

using Utilities;

public class Solution
{
  public int FindBottomLeftValue(TreeNode root)
  {
    int result = int.MinValue;
    int bottom = -1;
    if (root != null) Visit(root, 0);
    return result;

    void Visit(TreeNode node, int level)
    {
      if (level > bottom)
      {
        bottom = level;
        result = node.val;
      }
      if (node.left != null) Visit(node.left, level + 1);
      if (node.right != null) Visit(node.right, level + 1);
    }
  }

  public static void Main()
  {
  }
}
