using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 695. Max Area of Island

You are given an m x n binary matrix grid. An island is a group of 1's
(representing land) connected 4-directionally (horizontal or vertical)
You may assume all four edges of the grid are surrounded by water.

The area of an island is the number of cells with a value 1 in the
island.

Return the maximum area of an island in grid. If there is no island,
return 0.

APPROACH:
Go through the cells and when encountering an unvisited land, run
DFS to it to find all surrounding lands to get island size.
When a land (1) is visited, it is changed to sea (0) in the original
grid to keep track of visitations. It does not matter that with this
approach, we do not know if a cell is sea or already visited land.
*/


public class Solution
{
  public int MaxAreaOfIsland(int[][] grid)
  {
    int m = grid.Length;
    int n = grid[0].Length;
    int maxIsland = 0;
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (grid[i][j] == 1)
        {
          maxIsland = Math.Max(maxIsland, getIslandSize(i, j));
        }
      }
    }

    int getIslandSize(int rowIdx, int colIdx)
    {
      Queue<(int, int)> toBeVisited = new Queue<(int, int)>();
      toBeVisited.Enqueue((rowIdx, colIdx));
      int islandSize = 0;
      while (toBeVisited.Count > 0)
      {
        (int i, int j) = toBeVisited.Dequeue();
        if (grid[i][j] == 0) continue;
        islandSize++;
        if (i - 1 >= 0 && grid[i][j] == 1) toBeVisited.Enqueue((i - 1, j));
        if (i + 1 < m && grid[i][j] == 1) toBeVisited.Enqueue((i + 1, j));
        if (j - 1 >= 0 && grid[i][j] == 1) toBeVisited.Enqueue((i, j - 1));
        if (j + 1 < n && grid[i][j] == 1) toBeVisited.Enqueue((i, j + 1));
        grid[i][j] = 0;
      }
      return islandSize;
    }

    return maxIsland;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] jagged =
    {
      new int[]{0,1,0},
      new int[]{0,1,1},
      new int[]{0,1,0},
      new int[]{1,1,0},
      new int[]{1,0,0},
      new int[]{0,0,1},
    };
    Console.WriteLine(app.MaxAreaOfIsland(jagged));

  }
}
