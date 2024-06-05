/*
DIFFICULTY: Easy
QUESTION: 2894. Divisible and Non-divisible Sums Difference

DESCRIPTION:
You are given positive integers n and m.

Define two integers, num1 and num2, as follows:

    num1: The sum of all integers in the range [1, n] that are not divisible by m.
    num2: The sum of all integers in the range [1, n] that are divisible by m.

Return the integer num1 - num2.

INTUITION/APPROACH:
*/

public class Solution
{
  public int DifferenceOfSums(int n, int m)
  {
    int divisiblesSum = 0;
    int nonDivisiblesSum = 0;
    for (int i = 1; i <= n; i++)
    {
      if (i % m == 0)
      {
        divisiblesSum += i;
      }
      else
      {
        nonDivisiblesSum += i;
      }
    }
    return nonDivisiblesSum - divisiblesSum;
  }

  public static void Main()
  {
  }
}
