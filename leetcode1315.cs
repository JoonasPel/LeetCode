/*
DIFFICULTY: Medium
QUESTION: 1315. Sum of Nodes with Even-Valued Grandparent

DESCRIPTION:
Given the root of a binary tree, return the sum of values of nodes with an
even-valued grandparent. If there are no nodes with an even-valued grandparent,
return 0.

A grandparent of a node is the parent of its parent if it exists.

INTUITION/APPROACH:
Recursive travelse the tree and bring the earlier node (parent) to the next
node. If the parent's val is even, add the left and right nodes to the sum.
(earlier node is the grandparent of the left and right nodes.)
*/

using Utilities;

public class Solution
{
  public int SumEvenGrandparent(TreeNode root)
  {
    int sum = 0;
    TreeNode pseudo = new TreeNode(-1); // Used to remove earlier != null check
    if (root != null) Visit(root, pseudo);
    return sum;

    void Visit(TreeNode node, TreeNode earlier)
    {
      if (node.left != null)
      {
        if (earlier.val % 2 == 0) sum += node.left.val;
        Visit(node.left, node);
      }
      if (node.right != null)
      {
        if (earlier.val % 2 == 0) sum += node.right.val;
        Visit(node.right, node);
      }
    }
  }

  public static void Main()
  {
  }
}
