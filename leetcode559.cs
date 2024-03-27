/*
DIFFICULTY: Easy
QUESTION: 559. Maximum Depth of N-ary Tree

DESCRIPTION:
Given a n-ary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest path from the root
node down to the farthest leaf node.

Nary-Tree input serialization is represented in their level order traversal,
each group of children is separated by the null value (See examples).

INTUITION/APPROACH:
Recursively go through the tree and bring the current depth downwards while
updating the max depth to upper scope variable.
*/

using Utilities;

public class Solution
{
  public int MaxDepth(Node root)
  {
    int maxDepth = 0;
    if (root != null) Visit(root, 0);
    return maxDepth;

    void Visit(Node node, int depth)
    {
      maxDepth = Math.Max(maxDepth, ++depth);
      foreach (Node child in node.children)
      {
        Visit(child, depth);
      }
    }
  }

  public static void Main()
  {
  }
}

