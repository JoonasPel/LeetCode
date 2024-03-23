/*
DIFFICULTY: Easy
QUESTION: 2710. Remove Trailing Zeros From a String

Given a positive integer num represented as a string, return the integer num
without trailing zeros as a string.

INTUITION/APPROACH:
I like C#
*/


public class Solution
{
  public string RemoveTrailingZeros(string num)
  {
    return num.TrimEnd('0');
  }

  public static void Main()
  {
  }
}
