/*
DIFFICULTY: Easy
QUESTION: 563. Binary Tree Tilt

Given the root of a binary tree, return the sum of every tree node's tilt.

The tilt of a tree node is the absolute difference between the sum of all left
subtree node values and all right subtree node values. If a node does not have
a left child, then the sum of the left subtree node values is treated as 0.
The rule is similar if the node does not have a right child.

INTUITION/APPROACH:
Travelse the tree and return the subtree sums and calculate the tilt to a
"global" variable outside.
*/

using Utilities;

public class Solution
{
  public int FindTilt(TreeNode root)
  {
    int tilt = 0;
    if (root != null) Visit(root);
    return tilt;

    int Visit(TreeNode node)
    {
      if (node.left == null && node.right == null)
      {
        return node.val;
      }
      int tempSumLeft = 0;
      int tempSumRight = 0;
      if (node.left != null) tempSumLeft = Visit(node.left);
      if (node.right != null) tempSumRight = Visit(node.right);
      tilt += Math.Abs(tempSumLeft - tempSumRight);
      return tempSumLeft + tempSumRight + node.val;
    }
  }

  public static void Main()
  {
  }
}
