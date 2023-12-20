using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2643. Row With Maximum Ones

Given a m x n binary matrix mat, find the 0-indexed position of the row that
contains the maximum count of ones, and the number of ones in that row.

In case there are multiple rows that have the maximum count of ones, the row
with the smallest row number should be selected.

Return an array containing the index of the row, and the number of ones in it.

APPROACH:
Go through rows while keeping track of the highest number of ones found so far
and the index of that row. Also stop early if a row full of ones is found,
because that is the result whatever comes next. 
*/


public class Solution
{
  public int[] RowAndMaximumOnes(int[][] mat)
  {
    int maximumPossible = mat[0].Length;
    int maxSoFar = 0;
    int indexOfMaxSoFar = 0;
    int ones;
    for (int i = 0; i < mat.Length; i++)
    {
      ones = mat[i].Sum();
      if (ones == maximumPossible)
      {
        return new int[] { i, ones };
      }
      if (ones > maxSoFar)
      {
        maxSoFar = ones;
        indexOfMaxSoFar = i;
      }
    }
    return new int[] { indexOfMaxSoFar, maxSoFar };
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
