/*
DIFFICULTY: Easy
QUESTION: 2769. Find the Maximum Achievable Number

DESCRIPTION:
Given two integers, num and t. A number is achievable if it can become equal to
num after applying the following operation:

    Increase or decrease the number by 1, and simultaneously increase or
    decrease num by 1.

Return the maximum achievable number after applying the operation at most t times.

INTUITION/APPROACH:
*/

public class Solution
{
  public int TheMaximumAchievableX(int num, int t)
  {
    return num + 2 * t;
  }

  public static void Main()
  {
  }
}
