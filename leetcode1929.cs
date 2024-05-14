/*
DIFFICULTY: Easy
QUESTION: 1929. Concatenation of Array

DESCRIPTION:
Given an integer array nums of length n, you want to create an array ans of
length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n
(0-indexed).

Specifically, ans is the concatenation of two nums arrays.

Return the array ans.

INTUITION/APPROACH:
*/

public class Solution
{
  public int[] GetConcatenation(int[] nums)
  {
    int n = nums.Length;
    int[] ans = new int[n * 2];
    for (int i = 0; i < nums.Length; i++)
    {
      ans[i] = nums[i];
      ans[i + n] = nums[i];
    }
    return ans;
  }

  public static void Main()
  {
  }
}
