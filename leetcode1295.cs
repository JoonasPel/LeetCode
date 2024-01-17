using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1295. Find Numbers with Even Number of Digits

Given an array nums of integers, return how many of them contain an even number
of digits.

APPROACH:
Check if a number has even digits by dividing it by 10 until it is under 10.
*/

public class Solution
{
  public int FindNumbers(int[] nums)
  {
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (EvenDigits(nums[i])) result++;
    }
    return result;

    static bool EvenDigits(int num)
    {
      int x = 1;
      while (num >= 10)
      {
        x++;
        num /= 10;
      }
      return x % 2 == 0;
    }
  }
}