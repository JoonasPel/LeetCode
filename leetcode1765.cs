using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1765. Map of Highest Peak

You are given an integer matrix isWater of size m x n that represents
a map of land and water cells.

    If isWater[i][j] == 0, cell (i, j) is a land cell.
    If isWater[i][j] == 1, cell (i, j) is a water cell.

You must assign each cell a height in a way that follows these rules:

    The height of each cell must be non-negative.
    If the cell is a water cell, its height must be 0.
    Any two adjacent cells must have an absolute height difference of
    at most 1. A cell is adjacent to another cell if the former is
    directly north, east, south, or west of the latter (i.e., their
    sides are touching).

Find an assignment of heights such that the maximum height in the
matrix is maximized.

Return an integer matrix height of size m x n where height[i][j] is
cell (i, j)'s height. If there are multiple solutions, return any of
them.

APPROACH:
Start BFS from water cells and increase the heights by one for every
"layer" of the BFS. Save heights to another jagged array and use that
also as the visited/unvisited check when running BFS.
*/


public class Solution
{
  public int[][] HighestPeak(int[][] isWater)
  {
    int m = isWater.Length;
    int n = isWater[0].Length;
    int[][] heights = new int[m][];
    for (int i = 0; i < m; i++)
    {
      heights[i] = new int[n];
      Array.Fill(heights[i], -1);
    }
    Queue<(int, int)> cells = new Queue<(int, int)>();
    //find waters
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (isWater[i][j] == 1)
        {
          cells.Enqueue((i, j));
          heights[i][j] = 0;
        }
      }
    }
    // BFS
    while (cells.Count > 0)
    {
      (int i, int j) = cells.Dequeue();
      int currHeight = heights[i][j] + 1;
      if (i - 1 >= 0 && heights[i - 1][j] == -1)
      {
        heights[i - 1][j] = currHeight;
        cells.Enqueue((i - 1, j));
      }
      if (i + 1 < m && heights[i + 1][j] == -1)
      {
        heights[i + 1][j] = currHeight;
        cells.Enqueue((i + 1, j));
      }
      if (j - 1 >= 0 && heights[i][j - 1] == -1)
      {
        heights[i][j - 1] = currHeight;
        cells.Enqueue((i, j - 1));
      }
      if (j + 1 < n && heights[i][j + 1] == -1)
      {
        heights[i][j + 1] = currHeight;
        cells.Enqueue((i, j + 1));
      }
    }
    return heights;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] jagged = new int[][]
    {
      new int[]{0,0,1},
      new int[]{1,0,0},
      new int[]{0,0,0},
    };
    var result = app.HighestPeak(jagged);
    foreach (int[] row in result)
    {
      foreach (int val in row)
      {
        Console.Write($"{val},");
      }
      Console.WriteLine();
    }
  }
}
