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
  
  // remove static for leetcode
  public static bool IsSameTree(TreeNode? p, TreeNode? q) {
    if (p?.val != q?.val) { return false; }
    if(p?.left != null && q?.left != null)
    {
      if (!IsSameTree(p.left, q.left)) return false;
    }
    else if (!(p?.left == null && q?.left == null))
    {
      return false;
    }
    if(p?.right != null && q?.right != null)
    {
      if (!IsSameTree(p.right, q.right)) return false;
    }
    else if (!(p?.right == null && q?.right == null))
    {
      return false;
    }
    return true;
  }

  public static void Main()
  {
    TreeNode node2 = new TreeNode(2, null, null);
    TreeNode node3 = new TreeNode(3, null, null);
    TreeNode node1 = new TreeNode(1, node2, node3);

    TreeNode node2_1 = new TreeNode(3, null, null);
    TreeNode node3_1 = new TreeNode(2, null, null);
    TreeNode node1_1 = new TreeNode(1, node2_1, node3_1);

    //Console.Write(IsSameTree(node1, node1));
    Console.Write(IsSameTree(null, null));
  }
}