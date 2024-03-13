/*
DIFFICULTY: Easy
QUESTION: 2236. Root Equals Sum of Children

You are given the root of a binary tree that consists of exactly 3 nodes: 
the root, its left child, and its right child.

Return true if the value of the root is equal to the sum of the values of its
two children, or false otherwise.

INTUITION/APPROACH:
Trivial
*/

using Utilities;

public class Solution
{
  public bool CheckTree(TreeNode root)
  {
    if (root == null) return false;
    return root.val == root.left.val + root.right.val;
  }

  public static void Main()
  {
  }
}
