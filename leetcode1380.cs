using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1380. Lucky Numbers in a Matrix

Given an m x n matrix of distinct numbers, return all lucky numbers in
the matrix in any order.

A lucky number is an element of the matrix such that it is the minimum
element in its row and maximum in its column.

APPROACH:
Go through the matrix values while saving row minimum values into a 
Set and column maximum values into an array. Then check what numbers
are common in both array and set. Those are the lucky numbers.
*/


public class Solution
{

  public IList<int> LuckyNumbers(int[][] matrix)
  {
    HashSet<int> rowMinimums = new HashSet<int>();
    int[] colMaximums = new int[matrix[0].Length];
    int rowIndex = 0;
    foreach (int[] row in matrix)
    {
      int colIndex = 0;
      int min = int.MaxValue;
      foreach (int val in row)
      {
        colMaximums[colIndex] = Math.Max(colMaximums[colIndex], val);
        min = Math.Min(min, val);
        colIndex++;
      }
      rowMinimums.Add(min);
      rowIndex++;
    }
    return colMaximums.Intersect(rowMinimums).ToList();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
