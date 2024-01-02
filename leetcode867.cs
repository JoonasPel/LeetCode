using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 867. Transpose Matrix

APPROACH:
Create new result matrix that has as many rows as param matrix has columns, and
colums as many as param matrix has rows. Then just insert the values from the
param matrix. matrix[i][j] => result[j][i]
*/

public class Solution
{

  public int[][] Transpose(int[][] matrix)
  {
    int m = matrix.Length;
    int n = matrix[0].Length;
    int[][] result = new int[n][];
    for (int i = 0; i < n; i++)
    {
      result[i] = new int[m];
    }
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[j][i] = matrix[i][j];
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
