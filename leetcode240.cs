using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 240. Search a 2D Matrix II

Write an efficient algorithm that searches for a value target in an m x n
integer matrix matrix. This matrix has the following properties:

    Integers in each row are sorted in ascending from left to right.
    Integers in each column are sorted in ascending from top to bottom.

APPROACH:
Find the first row that starts with higher number than target. That and all
rows below it can't have the target. Start going the rows up while doing
binary search to every row to find the target.
*/


public class Solution
{

  public bool SearchMatrix(int[][] matrix, int target)
  {
    int m = matrix.Length;
    int i;
    for (i = 0; i < m; i++)
    {
      if (matrix[i][0] == target) return true;
      if (matrix[i][0] > target) break;
    }
    if (i == m) i--;
    while (i >= 0)
    {
      int result = Array.BinarySearch(matrix[i], target);
      if (result >= 0) return true;
      i--;
    }
    return false;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] matrix = new int[][]
    {
      new int[] {1, 4, 7, 11, 15},
      new int[] {2, 5, 8, 12, 19},
      new int[] {3, 6, 9, 16, 22},
      new int[] {10, 13, 14, 17, 24},
      new int[] {18, 21, 23, 26, 30}
    };
    Console.WriteLine(app.SearchMatrix(matrix, 23));
  }
}
