using System.Text;

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
  public static IList<string> BinaryTreePaths(TreeNode root)
  {
    if (root == null) return new List<string> {""};
    IList<string> paths = new List<string>();
    
    void Visit(TreeNode? node, string earlierPath)
    {
      if (node == null) return;
      // check if this node is leaf
      if (node.left == null && node.right == null)
      {
        earlierPath += node.val.ToString();
        paths.Add(earlierPath);
      }
      else
      {
        earlierPath += node.val.ToString() + "->";
      }
      Visit(node.left, earlierPath);
      Visit(node.right, earlierPath);
    }
    Visit(root, "");
    return paths;
  }

  public static void Main()
  {
    TreeNode node2 = new TreeNode(2, null, null);
    TreeNode node4 = new TreeNode(4, null, null);
    TreeNode node5 = new TreeNode(5, null, null);
    TreeNode node3 = new TreeNode(3, node4, node5);
    TreeNode node1 = new TreeNode(1, node2, node3);
    var paths = BinaryTreePaths(node1);
    foreach (string path in paths)
    {
      Console.WriteLine(path);
    }
  }

}
