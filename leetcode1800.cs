/*
DIFFICULTY: Easy
QUESTION: 1800. Maximum Ascending Subarray Sum

Given an array of positive integers nums, return the maximum possible sum of an
ascending subarray in nums.

A subarray is defined as a contiguous sequence of numbers in an array.

A subarray [numsl, numsl+1, ..., numsr-1, numsr] is ascending if for all i
where l <= i < r, numsi  < numsi+1. Note that a subarray of size 1 is ascending

APPROACH:
Loop through the numbers while keeping count of the highest sum found, if we
find a number that breaks the ascending subarray, we start counting new sum.
*/

public class Solution
{
  public int MaxAscendingSum(int[] nums)
  {
    if (nums.Length == 0) return 0;
    int maxSoFar = nums[0];
    int currentSum = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] > nums[i - 1])
      {
        currentSum += nums[i];
        continue;
      }
      else
      {
        maxSoFar = Math.Max(maxSoFar, currentSum);
        currentSum = nums[i];
      }
    }
    maxSoFar = Math.Max(maxSoFar, currentSum);
    return maxSoFar;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int res = app.MaxAscendingSum(new int[] { 10, 20, 30, 5, 10, 50 });
    Console.WriteLine(res);
  }
}
