using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 896. Monotonic Array

An array is monotonic if it is either monotone increasing or monotone
decreasing.

An array nums is monotone increasing if for all
i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if
for all i <= j, nums[i] >= nums[j].

Given an integer array nums, return true if the given array is
monotonic, or false otherwise.

APPROACH:
Check first and last number and see if the array has "potential" to be
increasing or decreasing. Then check if it is that by looping the
numbers and comparing.
*/


public class Solution
{
  public bool IsMonotonic(int[] nums)
  {
    if (nums.Length <= 2) return true;
    if (nums[0] > nums[^1])
    {
      return IsDecreasing(nums);
    }
    else
    {
      return IsIncreasing(nums);
    }

    bool IsIncreasing(int[] nums)
    {
      for (int i = 0; i < nums.Length - 1; i++)
      {
        if (nums[i] > nums[i + 1]) return false;
      }
      return true;
    }

    bool IsDecreasing(int[] nums)
    {
      for (int i = 0; i < nums.Length - 1; i++)
      {
        if (nums[i] < nums[i + 1]) return false;
      }
      return true;
    }
  }


  public static void Main()
  {
    Solution app = new Solution();
  }
}
