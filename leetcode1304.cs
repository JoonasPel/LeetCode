using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1304. Find N Unique Integers Sum up to Zero

Given an integer n, return any array containing n unique integers such that
they add up to 0.

APPROACH:
Add numbers 1,2,3,4... to the array and then one number negative sum of them.
So for example [X,1,2,3,4] and then the last number is -10. [-10,1,2,3,4]
*/


public class Solution
{

  public int[] SumZero(int n)
  {
    if (n == 0) return Array.Empty<int>();
    if (n == 1) return new int[1] { 0 };

    int[] result = new int[n];
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
      result[i] = -i;
      sum += i;
    }
    result[0] = sum;
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
