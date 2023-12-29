using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1464. Maximum Product of Two Elements in an Array

Given the array of integers nums, you will choose two different indices i and j
of that array. Return the maximum value of (nums[i]-1)*(nums[j]-1). 

APPROACH:
Sort and return (biggest value -1) * (second biggest value -1)
*/

public class Solution
{

  public int MaxProduct(int[] nums)
  {
    if (nums.Length < 2) return -1;
    Array.Sort(nums);
    return (nums[^1] - 1) * (nums[^2] - 1);
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
