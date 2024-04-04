/*
DIFFICULTY: Medium
QUESTION: 1038. Binary Search Tree to Greater Sum Tree

DESCRIPTION:
Given the root of a Binary Search Tree (BST), convert it to a Greater Tree such
that every key of the original BST is changed to the original key plus the sum
of all keys greater than the original key in BST.

As a reminder, a binary search tree is a tree that satisfies these constraints:

    The left subtree of a node contains only nodes with keys less than the
    node's key.
    The right subtree of a node contains only nodes with keys greater than the
    node's key.
    Both the left and right subtrees must also be binary search trees.

INTUITION/APPROACH:
Traverse the tree in order: right subtree, node, left subtree. This ensures
that the nodes are handled in descending order and a total sum can be added to
the nodes that are found, because all earlier nodes handled were larger.

This was pretty easy to think intuitively but writing it in code actually took
some time, even thou that the code is very simple eventually.
*/

using Utilities;

public class Solution
{
  public TreeNode BstToGst(TreeNode root)
  {
    if (root != null) Visit(root, 0);
    return root;

    int Visit(TreeNode node, int sumOfGreaters)
    {
      if (node.right != null) sumOfGreaters = Visit(node.right, sumOfGreaters);
      sumOfGreaters += node.val;
      node.val = sumOfGreaters;
      if (node.left != null) sumOfGreaters = Visit(node.left, sumOfGreaters);
      return sumOfGreaters;
    }
  }

  public static void Main()
  {
  }
}
