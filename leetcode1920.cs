/*
DIFFICULTY: Easy
QUESTION: 1920. Build Array from Permutation

DESCRIPTION:
Given a zero-based permutation nums (0-indexed), build an array ans of the same
length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it

A zero-based permutation nums is an array of distinct integers from 0 to
nums.length - 1 (inclusive).

Specifically, ans is the concatenation of two nums arrays.

Return the array ans.

INTUITION/APPROACH:
*/

public class Solution
{
  public int[] BuildArray(int[] nums)
  {
    int[] ans = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
      ans[i] = nums[nums[i]];
    }
    return ans;
  }

  public static void Main()
  {
  }
}
