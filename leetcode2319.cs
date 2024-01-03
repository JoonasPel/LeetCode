using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2319. Check if Matrix Is X-Matrix

A square matrix is said to be an X-Matrix if both of the following conditions
hold:

    All the elements in the diagonals of the matrix are non-zero.
    All other elements are 0.

Given a 2D integer array grid of size n x n representing a square matrix,
return true if grid is an X-Matrix. Otherwise, return false.

APPROACH:
A cell is in diagonal if row and column indexes are same OR row and column
indexes sum up to the length of square matrix side.
e.g. with matrix 17x17, a cell is in diagonal if i==j OR i+j == 16
So just loop through the cells and check that values are valid.
*/

public class Solution
{

  public bool CheckXMatrix(int[][] grid)
  {
    int m = grid.Length;
    int n = grid.Length;
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (i == j || i + j == m - 1)  // is in diagonal
        {
          if (grid[i][j] == 0) return false;
        }
        else
        {
          if (grid[i][j] != 0) return false;
        }
      }
    }
    return true;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
