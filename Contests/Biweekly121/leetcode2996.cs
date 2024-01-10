using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2996. Smallest Missing Integer Greater Than Sequential Prefix Sum
Q1 of Biweekly Contest 121. I did this during the contest.

You are given a 0-indexed array of integers nums.

A prefix nums[0..i] is sequential if, for all 1 <= j <= i,
nums[j] = nums[j - 1] + 1. In particular, the prefix consisting only of
nums[0] is sequential.

Return the smallest integer x missing from nums such that x is greater than or
equal to the sum of the longest sequential prefix.

APPROACH:
Check how long the prefix is and calculate its sum. Then sort the array and
using binarysearch multiple times, find the missing integer.
*/

public class Solution
{

  public int MissingInteger(int[] nums)
  {
    int tempSum = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] == nums[i - 1] + 1)
      {
        tempSum += nums[i];
      }
      else
      {
        break;
      }
    }
    Array.Sort(nums);
    int target = tempSum;
    while (true)
    {
      if (Array.BinarySearch(nums, target) < 0)
      {
        return target;
      }
      target++;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MissingInteger(new int[] { 1, 2, 3, 2, 5 }));
    Console.WriteLine(app.MissingInteger(new int[] { 3, 4, 5, 1, 12, 14, 13 }));
    Console.WriteLine(app.MissingInteger(new int[] { 38 }));
    Console.WriteLine(app.MissingInteger(new int[] { 14, 9, 6, 9, 7, 9, 10, 4, 9, 9, 4, 4 }));
  }
}
