/*
DIFFICULTY: Easy
QUESTION: 3065. Minimum Operations to Exceed Threshold Value I

DESCRIPTION:
You are given a 0-indexed integer array nums, and an integer k.

In one operation, you can remove one occurrence of the smallest element of nums.

Return the minimum number of operations needed so that all elements of the
array are greater than or equal to k.

INTUITION/APPROACH:
*/

public class Solution
{
  public int MinOperations(int[] nums, int k)
  {
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] < k) result++;
    }
    return result;
  }
}
