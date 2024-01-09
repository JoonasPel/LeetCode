using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1020. Number of Enclaves

You are given an m x n binary matrix grid, where 0 represents a sea cell and 1
represents a land cell.

A move consists of walking from one land cell to another adjacent
(4-directionally) land cell or walking off the boundary of the grid.

Return the number of land cells in grid for which we cannot walk off the
boundary of the grid in any number of moves.


APPROACH:
Similar to 1254. Number of Closed Islands but instead we calculate every cell.
So find a land cell, run BFS and check if we can find an edge. If we cant find
and edge, add all other land cells found with BFS to the enclaves count.
While running BFS, change visited land cells (1) to sea (0) to keep count of
visited cells.

*/

public class Solution
{
  public int NumEnclaves(int[][] grid)
  {
    int enclaves = 0;
    int m = grid.Length;
    int n = grid[0].Length;
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (grid[i][j] == 1)
        {
          BFS(i, j);
        }
      }
    }
    return enclaves;

    void BFS(int i, int j)
    {
      int possibleEnclaves = 0;
      bool edgeFound = false;
      var toBeVisited = new Queue<(int, int)>();
      toBeVisited.Enqueue((i, j));
      grid[i][j] = 0;
      int row, col;
      while (toBeVisited.Count > 0)
      {
        (row, col) = toBeVisited.Dequeue();
        possibleEnclaves++;
        VisitDirection(1, 0);
        VisitDirection(-1, 0);
        VisitDirection(0, 1);
        VisitDirection(0, -1);
      }

      void VisitDirection(int x, int y)
      {
        try
        {
          if (grid[row + x][col + y] == 1)
          {
            toBeVisited.Enqueue((row + x, col + y));
            grid[row + x][col + y] = 0;
          }
        }
        catch (IndexOutOfRangeException)
        {
          edgeFound = true;
        }
      }

      if (!edgeFound) enclaves += possibleEnclaves;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] jagged = new int[][]
    {
      new int[] {0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0},
      new int[] {1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1},
      new int[] {1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1},
      new int[] {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0},
      new int[] {1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1},
      new int[] {1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
      new int[] {0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0},
      new int[] {1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1},
      new int[] {1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0}
    };
    Console.WriteLine(app.NumEnclaves(jagged));
  }
}
