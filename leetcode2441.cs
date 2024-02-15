/*
DIFFICULTY: Easy
QUESTION: 2441. Largest Positive Integer That Exists With Its Negative

Given an integer array nums that does not contain any zeros, find the largest
positive integer k such that -k also exists in the array.

Return the positive integer k. If there is no such integer, return -1.

Constraints:

    1 <= nums.length <= 1000
    -1000 <= nums[i] <= 1000

INTUITION/APPROACH:
Solution is "constraint exploiting" as I call it.
Numbers are always in the range [-1000, 1000] so we can use a 1001 length arrs
as a super fast Set to find if something has been seen before.
*/

public class Solution
{
  public int FindMaxK(int[] nums)
  {
    int[] positiveExists = new int[1001];
    int[] negativeExists = new int[1001];
    int maxSoFar = -1;
    foreach (int num in nums)
    {
      if (num > 0)
      {
        positiveExists[num] = 1;
        if (negativeExists[num] == 1)
        {
          maxSoFar = Math.Max(maxSoFar, num);
        }
      }
      else if (num < 0)
      {
        negativeExists[-num] = 1;
        if (positiveExists[-num] == 1)
        {
          maxSoFar = Math.Max(maxSoFar, -num);
        }
      }
    }
    return maxSoFar;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
