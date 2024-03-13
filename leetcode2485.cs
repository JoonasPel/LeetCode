/*
DIFFICULTY: Easy
QUESTION: 2485. Find the Pivot Integer

Given a positive integer n, find the pivot integer x such that:

    The sum of all elements between 1 and x inclusively equals the sum of all
    elements between x and n inclusively.

Return the pivot integer x. If no such integer exists, return -1. It is
guaranteed that there will be at most one pivot index for the given input.

INTUITION/APPROACH:
Yes.
*/

public class Solution
{
  public int PivotInteger(int n)
  {
    for (double i = Math.Ceiling((double)n / 2); i <= n; i++)
    {
      if ((int)((1 + i) / 2 * i) == (int)((i + n) / 2 * (n - i + 1))) return (int)i;
    }
    return -1;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.PivotInteger(8));
    Console.WriteLine(app.PivotInteger(1));
    Console.WriteLine(app.PivotInteger(4));
  }
}
