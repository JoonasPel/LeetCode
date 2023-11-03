using System;
using System.Text;

/*
QUESTION: 2331. Evaluate Boolean Binary Tree

You are given the root of a full binary tree with the following properties:

    Leaf nodes have either the value 0 or 1, where 0 represents False and
    1 represents True.
    Non-leaf nodes have either the value 2 or 3, where 2 represents
    the boolean OR and 3 represents the boolean AND.

The evaluation of a node is as follows:

    If the node is a leaf node, the evaluation is the value of the node,
    i.e. True or False.
    Otherwise, evaluate the node's two children and apply the boolean operation
    of its value with the children's evaluations.

Return the boolean result of evaluating the root node.

A full binary tree is a binary tree where each node has either 0 or 2 children.

A leaf node is a node that has zero children.

APPROACH:
*/

public class Program
{

  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public bool EvaluateTree(TreeNode root)
  {
    if (root == null) return false;

    bool Visit(TreeNode node)
    {
      // full binary tree so no need to check both left and right for null
      if (node.left == null) return node.val == 0 ? false : true;
      bool leftVal = Visit(node.left);
      bool rightVal = Visit(node.right);
      return node.val == 2 ? leftVal || rightVal : leftVal && rightVal;
    }

    return Visit(root);
  }

  public static void Main()
  {
  }

}
