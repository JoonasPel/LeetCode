/*
DIFFICULTY: Medium
QUESTION: 53. Maximum Subarray

Given an integer array nums, find the subarray with the largest sum, and return
its sum.

APPROACH:
Kadane's algorithm, O(n). In every number, check if the the number itself is
bigger than earlier current sum + the number and update current sum. And also
update the biggest sum found so far that is the result.
*/

public class Solution
{
  public int MaxSubArray(int[] nums)
  {
    int maxSumSoFar = nums[0];
    int currentSum = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
      currentSum = Math.Max(nums[i], currentSum + nums[i]);
      maxSumSoFar = Math.Max(maxSumSoFar, currentSum);
    }
    return maxSumSoFar;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
