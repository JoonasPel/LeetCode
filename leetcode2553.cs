using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2553. Separate the Digits in an Array

Given an array of positive integers nums, return an array answer that consists
of the digits of each integer in nums after separating them in the same order
they appear in nums.

To separate the digits of an integer is to get all the digits it has in the
same order.

    For example, for the integer 10921, the separation of its digits is
    [1,0,9,2,1].

APPROACH:
Loop through the numbers and save the digits as separate integers to a list by
converting the whole number to a string and then looping the chars while
converting them to int and adding to the list

PERFORMANCE:
Runtime beats 100% of C# users
*/


public class Solution
{
  public int[] SeparateDigits(int[] nums)
  {
    IList<int> result = new List<int>();
    foreach (int num in nums)
    {
      string numStr = Convert.ToString(num);
      foreach (char c in numStr)
      {
        result.Add(Convert.ToInt32(c) - 48);
      }
    }
    return result.ToArray();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
