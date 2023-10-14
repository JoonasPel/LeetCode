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

public class Program {

  // Remove static keyword if copy-pasted to Leetcode.
  public static TreeNode? InvertTree(TreeNode? node) {
    if (node == null) return node;
    (node.right, node.left) = (node.left, node.right);
    InvertTree(node.right);
    InvertTree(node.left);
    return node;
  }

  public static void Main() {
    TreeNode node1 = new TreeNode(1);
    TreeNode node3 = new TreeNode(3);
    TreeNode node2 = new TreeNode(2, node1, node3);
    TreeNode node6 = new TreeNode(6);
    TreeNode node9 = new TreeNode(9);
    TreeNode node7 = new TreeNode(7, node6, node9);
    TreeNode root = new TreeNode(4, node2, node7);
    InvertTree(root);
  }

}



