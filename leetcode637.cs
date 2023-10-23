using System;

/*
QUESTION: 637. Average of Levels in Binary Tree:

Given the root of a binary tree, return the average value of the nodes on
each level in the form of an array. Answers within 10^-5 of the actual answer
will be accepted. 

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

  // remove static for leetcode
  public static IList<double> AverageOfLevels(TreeNode? root)
  {
    IList<int> Counts = new List<int>(); // how many nodes per level
    IList<double> Sums = new List<double>(); // summed up node values per level

    void Visit(TreeNode? node, int level)
    {
      if (node == null) return;
      if (level >= Counts.Count)
      {
        Counts.Add(1);
        Sums.Add(node.val);
      }
      else
      {
        Counts[level]++;
        Sums[level] += node.val;
      }
      level++;
      if (node.left != null) Visit(node.left, level);
      if (node.right != null) Visit(node.right, level);
    }

    Visit(root, 0);
    var averages = Sums.Zip(Counts, (sum, count) => sum / count).ToList();
    return averages;
  }


  public static void Main()
  {
    TreeNode node15 = new TreeNode(15, null, null);
    TreeNode node7 = new TreeNode(7, null, null);
    TreeNode node20 = new TreeNode(20, node15, node7);
    TreeNode node9 = new TreeNode(9, null, null);
    TreeNode root = new TreeNode(3, node9, node20);

    var sums = AverageOfLevels(root);

    foreach (var value in sums)
    {
      Console.WriteLine(value);
    }
  }

}
