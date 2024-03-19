/*
DIFFICULTY: Easy
QUESTION: 2427. Number of Common Factors

Given two positive integers a and b, return the number of common factors of
a and b.

An integer x is a common factor of a and b if x divides both a and b.

INTUITION/APPROACH:
*/

public class Solution
{

  public int CommonFactors(int a, int b)
  {
    int commonFactors = 0;
    int x = Math.Min(a, b);
    for (int i = 1; i <= x; i++)
    {
      if (a % i == 0 && b % i == 0)
      {
        commonFactors++;
      }
    }
    return commonFactors;
  }

  public static void Main()
  {
    Solution app = new();
    app.CommonFactors(12, 6);
  }
}

