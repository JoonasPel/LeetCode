using System;

public class Program
{
  public class TreeNode
  {
    public TreeNode? left;
    public TreeNode? right;
    public int val;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  /* APPROACH:
  */
  // remove static for leetcode.
  public static int DiameterOfBinaryTree(TreeNode root)
  {
    int tempDiameter = 0;

    int Visit(TreeNode node)
    {
      if (node == null) return 0;
      int deepnestLeft = Visit(node.left);
      int deepnestRight = Visit(node.right);
      tempDiameter = Math.Max(tempDiameter, deepnestLeft + deepnestRight);
      return Math.Max(++deepnestLeft, ++deepnestRight);
    }

    Visit(root);
    return tempDiameter;
  }


  public static void Main()
  {
  }

}
