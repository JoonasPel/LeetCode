using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1979. Find Greatest Common Divisor of Array

Given an integer array nums, return the greatest common divisor of the smallest
number and largest number in nums.

The greatest common divisor of two numbers is the largest positive integer that
evenly divides both numbers.


APPROACH:
Find the smallest and largest from nums array and use the ready GCD method
*/

public class Solution
{
  public int FindGCD(int[] nums)
  {
    int smallest = int.MaxValue;
    int largest = int.MinValue;
    foreach (int num in nums)
    {
      smallest = Math.Min(smallest, num);
      largest = Math.Max(largest, num);
    }
    // cannot overflow because GCD of two int32 cant' be larger than int32
    return (int)BigInteger.GreatestCommonDivisor(smallest, largest);
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
