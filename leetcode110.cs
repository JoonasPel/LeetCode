public class Program
{
  public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
  
  public class RecursionKillerException : Exception
  {
    public RecursionKillerException()
    {
    }

    public RecursionKillerException(string message)
        : base(message)
    {
    }
  }

  // remove static for leetcode and also use just Exception instead 
  // of RecursionKillerException. 
  public static bool IsBalanced(TreeNode root) {
    if (root == null) return true;
    bool unBalancedFound = false;

    int Visit(TreeNode? node, int currLevel)
    {
      if (node == null) return currLevel;
      currLevel++;
      int deepestLeft = Visit(node.left, currLevel);
      int deepestRight = Visit(node.right, currLevel);
      if (Math.Abs(deepestLeft-deepestRight) > 1)
      {
        // finding one unbalanced node is enough. no need to visit more nodes.
        unBalancedFound = true;
        throw new RecursionKillerException("kill recursion");
      }
      return Math.Max(deepestLeft, deepestRight);
    }

    try
    {
      Visit(root, 0);
    }
    catch (RecursionKillerException) {} // catches recursion killing exception.
    return !unBalancedFound; // tree is balanced if no unbalanced node found.
  }

  public static void Main()
  {
    TreeNode node2 = new TreeNode(2, null, null);
    TreeNode node4 = new TreeNode(4, null, null);
    TreeNode node6 = new TreeNode(6, null, null);
    TreeNode node5 = new TreeNode(5, null, node6);
    TreeNode node3 = new TreeNode(3, node4, node5);
    TreeNode node1 = new TreeNode(1, node2, node3);
    Console.Write(IsBalanced(node1));
  }

}
