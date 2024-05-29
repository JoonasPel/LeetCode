/*
DIFFICULTY: Medium
QUESTION: 1305. All Elements in Two Binary Search Trees

DESCRIPTION:
Given two binary search trees root1 and root2, return a list containing all the
integers from both trees sorted in ascending order.

Constraints:

    The number of nodes in each tree is in the range [0, 5000].
    -105 <= Node.val <= 105

INTUITION/APPROACH:
Visit both trees and add values into the same priority queue. Then dequeue all
values and put into a list that is initialized with high enough capacity to
not need O(n) reallocation.
*/

using Utilities;

public class Solution
{
  public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
  {
    PriorityQueue<int, int> queue = new();
    Visit(root1);
    Visit(root2);
    List<int> values = new(capacity: 10001);
    while (queue.Count > 0)
    {
      values.Add(queue.Dequeue());
    }
    return values;

    void Visit(TreeNode? node)
    {
      if (node == null) return;
      queue.Enqueue(node.val, node.val);
      Visit(node.left);
      Visit(node.right);
    }
  }

  public static void Main()
  {
  }
}
