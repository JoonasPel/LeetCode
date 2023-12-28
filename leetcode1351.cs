using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1351. Count Negative Numbers in a Sorted Matrix

Given a m x n matrix grid which is sorted in non-increasing order both row-wise
and column-wise, return the number of negative numbers in grid.

APPROACH:
Start from the bottom-right corner. Count negatives of that row and when 
encountering the first non-negative, move to the upper row (last column) and 
keep doing that. If encountering a row that has non-negative as the last number
there is not more negatives at all, because of the sorting. So stop func there
*/


public class Solution
{

  public int CountNegatives(int[][] grid)
  {
    int m = grid.Length;
    int n = grid[0].Length;
    int count = 0;
    for (int i = m - 1; i >= 0; i--)
    {
      if (grid[i][n - 1] >= 0) break;
      for (int j = n - 1; j >= 0; j--)
      {
        if (grid[i][j] < 0)
        {
          count++;
        }
        else
        {
          break;
        }
      }
    }
    return count;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
