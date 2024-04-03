/*
DIFFICULTY: Easy
QUESTION: 2455. Average Value of Even Numbers That Are Divisible by Three

DESCRIPTION:
Given an integer array nums of positive integers, return the average value of
all even integers that are divisible by 3.

Note that the average of n elements is the sum of the n elements divided by n
and rounded down to the nearest integer.

INTUITION/APPROACH:
*/


public class Solution
{
  public int AverageValue(int[] nums)
  {
    int sum = 0;
    int count = 0;
    foreach (int num in nums)
    {
      if (num % 2 == 0 && num % 3 == 0)
      {
        sum += num;
        count++;
      }
    }
    return count == 0 ? 0 : sum / count;
  }

  public static void Main()
  {
  }
}

