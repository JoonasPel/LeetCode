using Utilities;

/*
DIFFICULTY: Medium
QUESTION: 654. Maximum Binary Tree

You are given an integer array nums with no duplicates. A maximum binary tree
can be built recursively from nums using the following algorithm:

    Create a root node whose value is the maximum value in nums.
    Recursively build the left subtree on the subarray prefix to the left of
    the maximum value.
    Recursively build the right subtree on the subarray suffix to the right of
    the maximum value.

Return the maximum binary tree built from nums.

INTUITION/APPROACH:
Recursively build the tree and give the "remaining" nums arr to the deeper
recursion calls with left and right index pointer to make it faster. Another
but slower way would be making new array and giving it instead.
*/

public class Solution
{

  public TreeNode ConstructMaximumBinaryTree(int[] nums)
  {
    return Visit(0, nums.Length - 1);

    TreeNode? Visit(int leftPtr, int rightPtr)
    {
      if (rightPtr - leftPtr < 0) return null;
      (int max, int index) = GetMaxWithIndex(leftPtr, rightPtr);
      return new TreeNode(
        max, Visit(leftPtr, index - 1), Visit(index + 1, rightPtr));
    }

    (int max, int index) GetMaxWithIndex(int leftPtr, int rightPtr)
    {
      int max = int.MinValue;
      int index = -1;
      for (int i = leftPtr; i <= rightPtr; i++)
      {
        if (nums[i] > max)
        {
          max = nums[i];
          index = i;
        }
      }
      return (max, index);
    }
  }

  public static void Main()
  {
    Solution app = new();
    app.ConstructMaximumBinaryTree(new int[] { 3, 2, 1, 6, 0, 5 });
  }
}
