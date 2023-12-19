using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2500. Delete Greatest Value in Each Row

You are given an m x n matrix grid consisting of positive integers.

Perform the following operation until grid becomes empty:

    Delete the element with the greatest value from each row. If multiple such
    elements exist, delete any of them.
    Add the maximum of deleted elements to the answer.

Note that the number of columns decreases by one after each operation.

Return the answer after performing the operations described above.

APPROACH:
Sort all rows from highest to lowest. This way the result sum is just a sum of
the highest value in every column. To achieve this, loop every row and save
values to another array containing the highest value found in column N so far. 
*/


public class Solution
{

  public int DeleteGreatestValue(int[][] grid)
  {
    int n = grid[0].Length;
    foreach (int[] row in grid)
    {
      Array.Sort(row, (a, b) => b - a);
    }
    int[] maxOfEveryColumn = new int[n];
    foreach (int[] row in grid)
    {
      int column = 0;
      foreach (int columnValue in row)
      {
        maxOfEveryColumn[column] = Math.Max(
          maxOfEveryColumn[column], columnValue);
        column++;
      }
    }
    return maxOfEveryColumn.Sum();
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] arr = new int[][]
    {
      new int[] {1,2,4},
      new int[] {3,3,1},
    };
    Console.WriteLine(app.DeleteGreatestValue(arr));
  }
}
