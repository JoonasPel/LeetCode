using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1254. Number of Closed Islands

Given a 2D grid consists of 0s (land) and 1s (water).  An island is a maximal
4-directionally connected group of 0s and a closed island is an island totally
(all left, top, right, bottom) surrounded by 1s.

Return the number of closed islands.

APPROACH:
Loop the cells and find a zero. Then run BFS and if we find an edge (and
get IndexOutOfRangeException), this zero and all other zeros connected are not
in a closed island. But if we manage to run a BFS to a zero cell without
finding any edges, we found a closed island.
Zero cells are turned to one after visiting, so all cells get visited only once
*/

public class Solution
{
  public int ClosedIsland(int[][] grid)
  {
    int closedIslands = 0;
    int m = grid.Length;
    int n = grid[0].Length;
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (grid[i][j] == 0)
        {
          bool edgeFound = BFS(i, j);
          if (!edgeFound) closedIslands++;
        }
      }
    }
    return closedIslands;

    bool BFS(int i, int j)
    {
      bool edgeFound = false;
      var toBeVisited = new Queue<(int, int)>();
      toBeVisited.Enqueue((i, j));
      int row, col;
      while (toBeVisited.Count > 0)
      {
        (row, col) = toBeVisited.Dequeue();
        grid[row][col] = 1;
        VisitDirection(+1, 0);
        VisitDirection(-1, 0);
        VisitDirection(0, +1);
        VisitDirection(0, -1);
      }
      void VisitDirection(int x, int y)
      {
        try
        {
          if (grid[row + x][col + y] == 0)
          {
            toBeVisited.Enqueue((row + x, col + y));
          }
        }
        catch (IndexOutOfRangeException)
        {
          edgeFound = true;
        }
      }
      return edgeFound;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
