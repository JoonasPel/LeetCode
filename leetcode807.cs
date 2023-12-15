using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 807. Max Increase to Keep City Skyline

There is a city composed of n x n blocks, where each block contains a single
building shaped like a vertical square prism. You are given a 0-indexed n x n
integer matrix grid where grid[r][c] represents the height of the building
located in the block at row r and column c.

A city's skyline is the outer contour formed by all the building when viewing
the side of the city from a distance. The skyline from each cardinal direction
north, east, south, and west may be different.

We are allowed to increase the height of any number of buildings by any amount
(the amount can be different per building). The height of a 0-height building
can also be increased. However, increasing the height of a building should not
affect the city's skyline from any cardinal direction.

Return the maximum total sum that the height of the buildings can be increased
by without changing the city's skyline from any cardinal direction.


APPROACH:
Every building can be increased higher as long as it does not bypass any other
building in the same ROW or COLUMN. So we first calculate the highest building
in every row and in every column. Then go through every building and increase
it as much as possible so that it does not bypass the highest in the same row
NOR the highest in the same column. So basically the increase potential/cap is:
Math.Min(HighestInSameRow, HighestInSameColumn) - current height.

*/


public class Solution
{

  public int MaxIncreaseKeepingSkyline(int[][] grid)
  {
    // calculate max value in every row
    int[] rowMaximums = new int[grid.Length];
    int i = 0;
    foreach (var row in grid)
    {
      rowMaximums[i] = row.Max();
      i++;
    }
    // calculate max value in every column
    int[] columsMaximums = new int[grid.Length];
    foreach (var row in grid)
    {
      i = 0;
      foreach (int val in row)
      {
        columsMaximums[i] = Math.Max(columsMaximums[i], val);
        i++;
      }
    }
    // calculate possible increases to every building
    int totalIncrease = 0;
    int tempIncreasePotential;
    for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
    {
      for (int columnIndex = 0; columnIndex < grid.Length; columnIndex++)
      {
        tempIncreasePotential =
        Math.Min(rowMaximums[rowIndex], columsMaximums[columnIndex])
        - grid[rowIndex][columnIndex];
        if (tempIncreasePotential > 0)
        {
          totalIncrease += tempIncreasePotential;
        }
      }
    }
    return totalIncrease;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] jagged = new int[][]
    {
      new int[] {3,0,8,4},
      new int[] {2,4,5,7},
      new int[] {9,2,6,3},
      new int[] {0,3,1,0},
    };
    Console.WriteLine(app.MaxIncreaseKeepingSkyline(jagged));
  }
}
