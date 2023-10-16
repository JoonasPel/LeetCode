public class Program
{
  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  // remove static for leetcode
  public static bool IsValidBST(TreeNode root)
  {
    if (root == null) return true;
    bool validationViolationFound = false;

    (int, int) Visit(TreeNode node)
    {
      if (node.left == null && node.right == null)
      {
        return (node.val, node.val);
      }
      // stupid, yes.
      int newLowestLeft = 1000000000, newHighestLeft = -1000000000;
      int newLowestRight = 1000000000, newHighestRight = -1000000000;
      if (node.left != null)
      { 
        (int lowest, int highest) = Visit(node.left);
        if (node.val <= highest)
        {
          validationViolationFound = true; // no need to check more nodes.
          throw new Exception("kill recursion");
        }
        newLowestLeft = lowest; newHighestLeft = highest;
      }
      if (node.right != null)
      {
        (int lowest, int highest) = Visit(node.right);
        if (node.val >= lowest)
        {
          validationViolationFound = true; // no need to check more nodes.
          throw new Exception("kill recursion");
        }
        newLowestRight = lowest; newHighestRight = highest;
      }

      var x = Math.Min(newLowestLeft, newLowestRight);
      x = Math.Min(x, node.val);

      var y = Math.Max(newHighestLeft, newHighestRight);
      y = Math.Max(y, node.val);

      return (x, y);
    }

    try
    {
      Visit(root);
    }
    catch (Exception) {}
    return !validationViolationFound;
  }

  public static void Main()
  {
    TreeNode node1 = new TreeNode(1, null, null);
    TreeNode node3 = new TreeNode(3, null, null);
    TreeNode node6 = new TreeNode(6, null, null);
    TreeNode node5 = new TreeNode(5, null, node6);
    TreeNode node4 = new TreeNode(4, node3, node5);
    TreeNode root = new TreeNode(2, node1, node4);
    Console.Write(IsValidBST(root));
  }

}
