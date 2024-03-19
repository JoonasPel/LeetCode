/*
DIFFICULTY: Easy
QUESTION: 617. Merge Two Binary Trees

You are given two binary trees root1 and root2.

Imagine that when you put one of them to cover the other, some nodes of the
two trees are overlapped while the others are not. You need to merge the two
trees into a new binary tree. The merge rule is that if two nodes overlap, then
sum node values up as the new value of the merged node. Otherwise, the NOT null
node will be used as the node of the new tree.

Return the merged tree.

Note: The merging process must start from the root nodes of both trees.

INTUITION/APPROACH:
Recursively travelse the tree while creating a new tree. Give the next node of
the new tree as ref param so the new node can be created and assigned in the
next call.
*/

using Utilities;

public class Solution
{
  public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
  {
    if (root1 == null && root2 == null) return null;
    TreeNode newHead = new(-1, null, null)
    {
      val = (root1?.val ?? 0) + (root2?.val ?? 0)
    };
    Visit(root1?.left, root2?.left, ref newHead.left);
    Visit(root1?.right, root2?.right, ref newHead.right);
    return newHead;

    void Visit(TreeNode? node1, TreeNode? node2, ref TreeNode? newNode)
    {
      if (node1 == null && node2 == null) return;
      newNode = new((node1?.val ?? 0) + (node2?.val ?? 0), null, null);
      Visit(node1?.left, node2?.left, ref newNode.left);
      Visit(node1?.right, node2?.right, ref newNode.right);
    }
  }
}

