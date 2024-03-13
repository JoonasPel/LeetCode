/*
DIFFICULTY: Easy
QUESTION: 144. Binary Tree Preorder Traversal

Given the root of a binary tree, return the preorder traversal of its nodes'
values.

INTUITION/APPROACH:
Recursive and Iterative solutions implemented.
Recursive is pretty trivial. Iterative uses stack and puts right node first and
then left node on top of it, so left subtree is explored first.
*/

using Utilities;

public class Solution
{
  public IList<int> PreorderTraversal(TreeNode root)
  {
    return PreorderTraversalIterative(root);
    //return PreorderTraversalRecursive(root);
  }

  public IList<int> PreorderTraversalIterative(TreeNode root)
  {
    IList<int> traversal = new List<int>();
    Stack<TreeNode> stack = new();
    if (root != null) stack.Push(root);
    while (stack.Count > 0)
    {
      TreeNode node = stack.Pop();
      traversal.Add(node.val);
      if (node.right != null) stack.Push(node.right);
      if (node.left != null) stack.Push(node.left);
    }
    return traversal;
  }

  public IList<int> PreorderTraversalRecursive(TreeNode root)
  {
    IList<int> traversal = new List<int>();
    Visit(root);
    return traversal;
    void Visit(TreeNode node)
    {
      if (node == null) return;
      traversal.Add(node.val);
      Visit(node.left);
      Visit(node.right);
    }
  }
}
