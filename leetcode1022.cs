/*
DIFFICULTY: Easy
QUESTION: 1022. Sum of Root To Leaf Binary Numbers

You are given the root of a binary tree where each node has a value 0 or 1.
Each root-to-leaf path represents a binary number starting with the most
significant bit.

    For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could
    represent 01101 in binary, which is 13.

For all leaves in the tree, consider the numbers represented by the path from
the root to that leaf. Return the sum of these numbers.

The test cases are generated so that the answer fits in a 32-bits integer.

INTUITION/APPROACH:
Recursively travelse the tree while keeping count of the binary numbers with a
string parameter. When finding a leaf node, convert the string binary number
to int and sum to a "global" variable.
*/

using Utilities;

public class Solution
{
  public int SumRootToLeaf(TreeNode root)
  {
    int sum = 0;
    if (root != null) Visit(root, "");
    return sum;

    void Visit(TreeNode node, string binary)
    {
      binary += node.val;
      if (node.left == null && node.right == null)
      {
        sum += Convert.ToInt32(binary, 2);
      }
      else
      {
        if (node.left != null) Visit(node.left, binary);
        if (node.right != null) Visit(node.right, binary);
      }
    }
  }

  public static void Main()
  {
  }
}
