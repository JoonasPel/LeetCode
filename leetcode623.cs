/*
DIFFICULTY: Medium
QUESTION: 623. Add One Row to Tree

DESCRIPTION:
Given the root of a binary tree and two integers val and depth, add a row of
nodes with value val at the given depth depth.

Note that the root node is at depth 1.

The adding rule is:

    Given the integer depth, for each not null tree node cur at the depth
    depth - 1, create two tree nodes with value val as cur's left subtree root
    and right subtree root.
    cur's original left subtree should be the left subtree of the new left
    subtree root.
    cur's original right subtree should be the right subtree of the new right
    subtree root.
    If depth == 1 that means there is no depth depth - 1 at all, then create a
    tree node with value val as the new root of the whole original tree, and
    the original tree is the new root's left subtree.

INTUITION/APPROACH:
Travelse the tree while counting the depth. When finding a node that has one
smaller depth that target depth, insert the new nodes to its left and right
and return (no need to travelse that subtree further).
*/

using Utilities;

public class Solution
{
  public TreeNode AddOneRow(TreeNode root, int val, int depth)
  {
    if (depth == 1) return new TreeNode(val, root, null);
    if (root != null) Visit(root, 1);
    return root;

    void Visit(TreeNode node, int currDepth)
    {
      if (currDepth == depth - 1)
      {
        TreeNode oldLeft = node.left;
        TreeNode oldRight = node.right;
        node.left = new TreeNode(val, oldLeft, null);
        node.right = new TreeNode(val, null, oldRight);
      }
      else
      {
        if (node.left != null) Visit(node.left, currDepth + 1);
        if (node.right != null) Visit(node.right, currDepth + 1);
      }
    }
  }

  public static void Main()
  {
  }
}
