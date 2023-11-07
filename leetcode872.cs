using System;
using System.Text;

/*
QUESTION: 872. Leaf-Similar Trees

Consider all the leaves of a binary tree, from left to right order,
the values of those leaves form a leaf value sequence.

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

  public bool LeafSimilar(TreeNode root1, TreeNode root2)
  {
    IList<int> root1Leaves = new List<int>();
    bool isRoot1 = true;
    IList<int> root2Leaves = new List<int>();
    void Visit(TreeNode node)
    {
      if (node.left == null && node.right == null)
      {
        if (isRoot1)
        {
          root1Leaves.Add(node.val);
        }
        else
        {
          root2Leaves.Add(node.val);
        }

      }
      if (node.left != null) Visit(node.left);
      if (node.right != null) Visit(node.right);
    }
    if (root1 != null) Visit(root1);
    isRoot1 = false;
    if (root2 != null) Visit(root2);
    return root1Leaves.SequenceEqual(root2Leaves);
  }

  public static void Main()
  {
  }

}
