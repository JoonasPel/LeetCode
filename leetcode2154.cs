﻿using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2154. Keep Multiplying Found Values by Two

You are given an array of integers nums. You are also given an integer
original which is the first number that needs to be searched for in
nums.

You then do the following steps:

    If original is found in nums, multiply it by two
    (i.e., set original = 2 * original).
    Otherwise, stop the process.
    Repeat this process with the new number as long as you keep
    finding the number.

Return the final value of original.

APPROACH:
Sort the array and use binary search to find the original. 
*/


public class Solution
{

  public int FindFinalValue(int[] nums, int original)
  {
    Array.Sort(nums);
    while (true)
    {
      if (Array.BinarySearch(nums, original) < 0)
      {
        return original;
      }
      else
      {
        original *= 2;
      }
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}