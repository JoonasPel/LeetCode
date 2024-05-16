/*
DIFFICULTY: Easy
QUESTION: 1637. Widest Vertical Area Between Two Points Containing No Points

DESCRIPTION:
Given n points on a 2D plane where points[i] = [xi, yi], Return the widest
vertical area between two points such that no points are inside the area.

A vertical area is an area of fixed-width extending infinitely along the y-axis
(i.e., infinite height). The widest vertical area is the one with the maximum
width.

Note that points on the edge of a vertical area are not considered included in
the area.

INTUITION/APPROACH:
Only x-axis coordinates matter. Sort all x-axis coordinates and find largest
difference between two adjacent points. (There is no points between them because
the points are sorted).
*/

public class Solution
{
  public int MaxWidthOfVerticalArea(int[][] points)
  {
    int[] xPoints = new int[points.Length];
    for (int i = 0; i < points.Length; i++)
    {
      xPoints[i] = points[i][0];
    }
    Array.Sort(xPoints);
    int maxWidth = 0;
    for (int i = 0; i < xPoints.Length - 1; i++)
    {
      maxWidth = Math.Max(maxWidth, xPoints[i + 1] - xPoints[i]);
    }
    return maxWidth;
  }

  public static void Main()
  {
    Solution app = new();
    app.MaxWidthOfVerticalArea([[1, 2], [5, 3], [9, 9]]);
  }
}
