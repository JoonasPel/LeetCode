class Program {
  public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null){
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  // remove static keyword if copy-pasted and run in leetcode!
  static public int RangeSumBST(TreeNode root, int low, int high) {
    int Sum = 0;
    int tempVal;
    void Visit(TreeNode node) {
      if (node == null) return;
      tempVal = node.val;
      if (low <= tempVal && tempVal <= high) {
        Sum += node.val;
      }
      // BST so no need to visit next nodes if this node val
      // is already too high or low.
      if (tempVal >= low) Visit(node.left);
      if (tempVal <= high) Visit(node.right); 
    }
    Visit(root);
    return Sum;
  }

  static public void Main() {
    // create BST
    TreeNode node3 = new TreeNode(3);
    TreeNode node7 = new TreeNode(7);
    TreeNode node5 = new TreeNode(5, node3, node7);
    TreeNode node18 = new TreeNode(18);
    TreeNode node15 = new TreeNode(15, null, node18);
    TreeNode node10 = new TreeNode(10, node5, node15);

    int result = RangeSumBST(node10, 7, 15);
    Console.WriteLine(result);
  }
}
