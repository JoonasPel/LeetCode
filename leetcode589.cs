/*
DIFFICULTY: Easy
QUESTION: 589. N-ary Tree Preorder Traversal

Given the root of an n-ary tree, return the preorder traversal of its nodes'
values.

Nary-Tree input serialization is represented in their level order traversal.
Each group of children is separated by the null value (See examples)

Follow up: Recursive solution is trivial, could you do it iteratively?

INTUITION/APPROACH:
Use a Stack to iteratively go through the nodes. Children needs to be reversed
to make them go to the Stack in the right order (left-most last)
*/

using Utilities;

public class Solution
{
  public IList<int> Preorder(Node root)
  {
    if (root == null) return [];
    Stack<Node> nodes = new();
    nodes.Push(root);
    IList<int> result = new List<int>();
    while (nodes.Count > 0)
    {
      Node current = nodes.Pop();
      result.Add(current.val);
      IList<Node> children = current.children.Reverse().ToArray();
      foreach (Node child in children)
      {
        nodes.Push(child);
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
