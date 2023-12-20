using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2428. Maximum Sum of an Hourglass

You are given an m x n integer matrix grid.

We define an hourglass as a part of the matrix with the following form:
https://leetcode.com/problems/maximum-sum-of-an-hourglass/description/

Return the maximum sum of the elements of an hourglass.

Note that an hourglass cannot be rotated and must be entirely contained
within the matrix.

APPROACH:
Go through the grid and calculate the sum of every possible hourglass shape.
Top-left corner of the hourglass cannot start from the last two rows or cols,
because there is no space for the hourglass. Thats why m-2 and n-2 are used.
*/


public class Solution
{
  public int MaxSum(int[][] grid)
  {
    int m = grid.Length;
    int n = grid[0].Length;
    int maxSoFar = 0;
    for (int rowIdx = 0; rowIdx < m - 2; rowIdx++)
    {
      int colIdx = 0;
      while (colIdx < n - 2)
      {
        int sum = grid[rowIdx][colIdx..(colIdx + 3)].Sum() +
          grid[rowIdx + 1][colIdx + 1] +
          grid[rowIdx + 2][colIdx..(colIdx + 3)].Sum();
        maxSoFar = Math.Max(maxSoFar, sum);
        colIdx++;
      }
    }
    return maxSoFar;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
