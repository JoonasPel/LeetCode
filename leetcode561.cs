/*
DIFFICULTY: Easy
QUESTION: 561. Array Partition

Given an integer array nums of 2n integers, group these integers into n pairs
(a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi) for all i is
maximized. Return the maximized sum.

INTUITION/APPROACH:
The maximized sum happens when always combining the two smallest together, then
3rd and 4th smallest and so on. So we sort array ascending and calculate the
sum of every second item starting from index zero.
*/


public class Solution
{
  public int ArrayPairSum(int[] nums)
  {
    Array.Sort(nums);
    int result = 0;
    for (int i = 0; i < nums.Length; i += 2)
    {
      result += nums[i];
    }
    return result;
  }

  public static void Main()
  {
  }
}
