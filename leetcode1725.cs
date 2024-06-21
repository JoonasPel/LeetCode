/*
DIFFICULTY: Easy
QUESTION: 1725. Number Of Rectangles That Can Form The Largest Square

DESCRIPTION:
You are given an array rectangles where rectangles[i] = [li, wi] represents the
ith rectangle of length li and width wi.

You can cut the ith rectangle to form a square with a side length of k if both
k <= li and k <= wi. For example, if you have a rectangle [4,6], you can cut it
to get a square with a side length of at most 4.

Let maxLen be the side length of the largest square you can obtain from any of
the given rectangles.

Return the number of rectangles that can make a square with a side length of
maxLen.

INTUITION/APPROACH:
*/

public class Solution
{
  public int CountGoodRectangles(int[][] rectangles)
  {
    int maxLength = 0;
    int count = 0;
    foreach (int[] rectangle in rectangles)
    {
      int length = Math.Min(rectangle[0], rectangle[1]);
      if (length == maxLength)
      {
        count++;
      }
      else if (length > maxLength)
      {
        maxLength = length;
        count = 1;
      }
    }
    return count;
  }

  public static void Main()
  {
    Solution app = new();
    app.CountGoodRectangles([[5, 8], [3, 9], [5, 12], [16, 5]]);
  }
}
