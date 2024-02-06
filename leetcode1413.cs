/*
DIFFICULTY: Easy
QUESTION: 1413. Minimum Value to Get Positive Step by Step Sum

Given an array of integers nums, you start with an initial positive value
startValue.

In each iteration, you calculate the step by step sum of startValue plus
elements in nums (from left to right).

Return the minimum positive value of startValue such that the step by step sum
is never less than 1.

APPROACH:
Start with current val 0 and loop through the nums while summing the values
to current, and tracking the smallest current bottom. If current gets as low as
-7 for example, we need a starting value of 8. If the current stays above 0 all
the time, we can have a startValue of 1.
*/

public class Solution
{
  public int MinStartValue(int[] nums)
  {
    int smallestSoFar = int.MaxValue;
    int current = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      current += nums[i];
      smallestSoFar = Math.Min(smallestSoFar, current);
    }
    return smallestSoFar <= 0 ? -smallestSoFar + 1 : 1;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
