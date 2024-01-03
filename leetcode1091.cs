using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1091. Shortest Path in Binary Matrix

Given an n x n binary matrix grid, return the length of the shortest clear path
in the matrix. If there is no clear path, return -1.

A clear path in a binary matrix is a path from the top-left cell (i.e., (0, 0))
to the bottom-right cell (i.e., (n - 1, n - 1)) such that:

    All the visited cells of the path are 0.
    All the adjacent cells of the path are 8-directionally connected
    (i.e.,they are different and they share an edge or a corner).

The length of a clear path is the number of visited cells of this path.

APPROACH:
Using BFS we can find the shortest path. We only want to travelse through zero
values so the 0 values can be changed to 1, marking the cells visited.
The path length is saved with the cells in the BFS queue.
*/

public class Solution
{

  public int ShortestPathBinaryMatrix(int[][] grid)
  {
    if (grid[0][0] != 0) return -1; // "trivial" case when we start at value 1
    int m = grid.Length;
    int n = grid[0].Length;
    Queue<(int i, int j, int pathLength)> queue = new Queue<(int, int, int)>();
    int pathLengthAtStart = 0;
    queue.Enqueue((0, 0, pathLengthAtStart));

    while (queue.Count > 0)
    {
      (int i, int j, int currPathLength) = queue.Dequeue();
      if (i == m - 1 && j == n - 1) return currPathLength + 1; // goal found
      grid[i][j] = 1;

      Check(i - 1, j - 1);
      Check(i - 1, j);
      Check(i - 1, j + 1);
      Check(i + 1, j - 1);
      Check(i + 1, j);
      Check(i + 1, j + 1);
      Check(i, j - 1);
      Check(i, j + 1);

      void Check(int i, int j)
      {
        try
        {
          if (grid[i][j] == 0)
            queue.Enqueue((i, j, currPathLength + 1));
        }
        catch (IndexOutOfRangeException) { }
      }
    }

    return -1;  // didnt find any path
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
