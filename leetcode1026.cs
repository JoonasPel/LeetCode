/*
DIFFICULTY: Medium
QUESTION: 1026. Maximum Difference Between Node and Ancestor

Given the root of a binary tree, find the maximum value v for which there exist
different nodes a and b where v = |a.val - b.val| and a is an ancestor of b.

A node a is an ancestor of b if either: any child of a is equal to b or any
child of a is an ancestor of b.

INTUITION/APPROACH:
Recursively go through the tree and give the largest and smallest ancestor to
subtrees to calculate the largest difference.
*/

using Utilities;

public class Solution
{
  public int MaxAncestorDiff(TreeNode root)
  {
    int maxDifference = int.MinValue;
    if (root != null) Visit(root, root.val, root.val);
    return maxDifference;

    void Visit(TreeNode node, int min, int max)
    {
      maxDifference = Math.Max(
        maxDifference,
        Math.Max(Math.Abs(node.val - min), Math.Abs(node.val - max))
        );
      min = Math.Min(min, node.val);
      max = Math.Max(max, node.val);
      if (node.left != null) Visit(node.left, min, max);
      if (node.right != null) Visit(node.right, min, max);
    }
  }

  public static void Main()
  {
  }
}
