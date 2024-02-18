/*
DIFFICULTY: Medium
QUESTION: 3040. Maximum Number of Operations With the Same Score II

Given an array of integers called nums, you can perform any of the following
operation while nums contains at least 2 elements:

    Choose the first two elements of nums and delete them.
    Choose the last two elements of nums and delete them.
    Choose the first and the last elements of nums and delete them.

The score of the operation is the sum of the deleted elements.

Your task is to find the maximum number of operations that can be performed,
such that all operations have the same score.

Return the maximum number of operations possible that satisfy the condition
mentioned above.

INTUITION/APPROACH:
I did this during contest but could not make it fast enough to pass. The
problem was that I did not realize to use memoization, to keep track of the
subproblems already seen and not to solve them again. It is added now.

The approach recursively checks all possible(legal) ways to do operations and
finds the largest possible score. The subarrays are given to deeper recursive
calls by keeping track of a left and right index pointer, so no need to
actually create any new arrays.
*/

public class Solution
{
  public int MaxOperations(int[] nums)
  {
    HashSet<(int, int)> memoization = new();
    int Visit(int[] nums, int operations, int sumNeeded, int leftPtr, int rightPtr)
    {
      bool subProblemAlreadySeen = !memoization.Add((leftPtr, rightPtr));
      if (rightPtr - leftPtr < 1 || subProblemAlreadySeen) return operations;

      int operations1 = 0;
      int operations2 = 0;
      int operations3 = 0;

      // firsts
      if (nums[leftPtr] + nums[leftPtr + 1] == sumNeeded || sumNeeded == -1)
      {
        operations1 = Visit(
          nums, operations + 1, nums[leftPtr] + nums[leftPtr + 1], leftPtr + 2, rightPtr);
      }

      // lasts
      if (nums[rightPtr] + nums[rightPtr - 1] == sumNeeded || sumNeeded == -1)
      {
        operations2 = Visit(
          nums, operations + 1, nums[rightPtr] + nums[rightPtr - 1], leftPtr, rightPtr - 2);
      }

      //first and last
      if (nums[leftPtr] + nums[rightPtr] == sumNeeded || sumNeeded == -1)
      {
        operations3 = Visit
        (nums, operations + 1, nums[leftPtr] + nums[rightPtr], leftPtr + 1, rightPtr - 1);
      }

      return Math.Max(Math.Max(operations1, operations2), Math.Max(operations, operations3));
    }

    return Visit(nums, operations: 0, -1, leftPtr: 0, rightPtr: nums.Length - 1);
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MaxOperations(
      new int[] { 1, 9, 7, 3, 2, 7, 4, 12, 2, 6 }));  //2
    Console.WriteLine(app.MaxOperations(new int[] { 3, 2, 1, 2, 3, 4 })); //3
    Console.WriteLine(app.MaxOperations(new int[] { 3, 2, 6, 1, 4 })); // 2
    Console.WriteLine(app.MaxOperations(new int[] { 2, 2, 1, 2, 1 }));  //2
  }
}
