using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1267. Count Servers that Communicate

You are given a map of a server center, represented as a m * n integer matrix
grid, where 1 means that on that cell there is a server and 0 means that it is
no server. Two servers are said to communicate if they are on the same row or
on the same column.

Return the number of servers that communicate with any other server.

APPROACH:
Save seen servers to a Set (by their row and col index). Go through the matrix
and when finding a server, check same row and column for more. Then jump to
the first column of the next row and keep going. Slow solution.
*/


public class Solution
{

  public int CountServers(int[][] grid)
  {
    int m = grid.Length;
    int n = grid[0].Length;
    HashSet<(int, int)> seenServers = new HashSet<(int, int)>();
    int serversCommunicating = 0;
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (grid[i][j] == 1 && !seenServers.Contains((i, j)))
        {
          bool found = FindOtherServers(i, j);
          if (found) serversCommunicating++;
          break;
        }
      }
    }
    return serversCommunicating;

    bool FindOtherServers(int i, int j)
    {
      bool serversFound = false;
      void CheckForServer(int row, int col)
      {
        if (grid[row][col] == 1)
        {
          serversFound = true;
          if (!seenServers.Contains((row, col)))
          {
            serversCommunicating++;
            seenServers.Add((row, col));
          }
        }
      }
      for (int row = i; row > 0;)
      {
        row--;
        CheckForServer(row, j);
      }
      for (int row = i; row < m - 1;)
      {
        row++;
        CheckForServer(row, j);
      }
      for (int col = j; col > 0;)
      {
        col--;
        CheckForServer(i, col);
      }
      for (int col = j; col < n - 1;)
      {
        col++;
        CheckForServer(i, col);
      }
      return serversFound;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
