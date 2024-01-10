using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 3000. Maximum Area of Longest Diagonal Rectangle
Q1 of Weekly Contest 379. I did this during the contest.

You are given a 2D 0-indexed integer array dimensions.

For all indices i, 0 <= i < dimensions.length, dimensions[i][0] represents the
length and dimensions[i][1] represents the width of the rectangle i.

Return the area of the rectangle having the longest diagonal. If there are
multiple rectangles with the longest diagonal, return the area of the
rectangle having the maximum area.

APPROACH:
Loop through the rectangles and save the highest one. Remember to check
if there are multiple highest ones and select the maximum area from those.
*/

public class Solution
{

  public int AreaOfMaxDiagonal(int[][] dimensions)
  {
    double maxDiagonal = 0;
    int areaOfMaxRectangle = 0;
    foreach (int[] rectangle in dimensions)
    {
      double diagonal = Math.Sqrt(
        rectangle[0] * rectangle[0] + rectangle[1] * rectangle[1]);
      if (diagonal > maxDiagonal)
      {
        maxDiagonal = diagonal;
        areaOfMaxRectangle = rectangle[0] * rectangle[1];
      }
      else if (diagonal == maxDiagonal)
      {
        if (rectangle[0] * rectangle[1] > areaOfMaxRectangle)
        {
          maxDiagonal = diagonal;
          areaOfMaxRectangle = rectangle[0] * rectangle[1];
        }
      }
    }
    return areaOfMaxRectangle;
  }

  public static void Main()
  {
    Solution app = new Solution();

  }
}
