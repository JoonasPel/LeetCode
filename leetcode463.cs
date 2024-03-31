/*
DIFFICULTY: Easy
QUESTION: 463. Island Perimeter

DESCRIPTION:
You are given row x col grid representing a map where grid[i][j] = 1
represents land and grid[i][j] = 0 represents water.

Grid cells are connected horizontally/vertically (not diagonally).
The grid is completely surrounded by water, and there is exactly one
island (i.e., one or more connected land cells).

The island doesn't have "lakes", meaning the water inside isn't
connected to the water around the island. One cell is a square with
side length 1. The grid is rectangular, width and height don't 
exceed 100. Determine the perimeter of the island.

INTUITION/APPROACH:
It is a bit weird but whatever.
For every land check if the horizontal/vertical neighbour is either
water of out of bounds and if yes, it adds one to the perimeter.
*/


public class Solution
{

  public int IslandPerimeter(int[][] grid)
  {
    int perimeter = 0;
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid[0].Length; j++)
      {
        if (grid[i][j] == 1)
        {
          perimeter += checkBorders(i, j);
        }
      }
    }
    return perimeter;

    int checkBorders(int row, int col)
    {
      int nonLandBorder = 0;
      try
      {
        if (grid[row - 1][col] == 0) nonLandBorder++;
      }
      catch (IndexOutOfRangeException)
      {
        nonLandBorder++;
      }
      try
      {
        if (grid[row + 1][col] == 0) nonLandBorder++;
      }
      catch (IndexOutOfRangeException)
      {
        nonLandBorder++;
      }
      try
      {
        if (grid[row][col - 1] == 0) nonLandBorder++;
      }
      catch (IndexOutOfRangeException)
      {
        nonLandBorder++;
      }
      try
      {
        if (grid[row][col + 1] == 0) nonLandBorder++;
      }
      catch (IndexOutOfRangeException)
      {
        nonLandBorder++;
      }
      return nonLandBorder;
    }
  }

  public static void Main()
  {
  }
}
