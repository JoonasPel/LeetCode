/*
DIFFICULTY: Easy
QUESTION: 2778. Sum of Squares of Special Elements

You are given a 1-indexed integer array nums of length n.

An element nums[i] of nums is called special if i divides n, i.e. n % i == 0.

Return the sum of the squares of all special elements of nums.

INTUITION/APPROACH:

*/

public class Solution
{
  public int SumOfSquares(int[] nums)
  {
    int n = nums.Length;
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
      if (n % (i + 1) == 0)
      {
        sum += Math.Pow(nums[i], 2);
      }
    }
    return (int)sum;
  }

  public static void Main()
  {
  }
}
