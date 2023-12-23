using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 10032. Find Polygon With the Largest Perimeter
Q2 of Biweekly Contest 120. I did this during the contest.

You are given an array of positive integers nums of length n.

A polygon is a closed plane figure that has at least 3 sides. The
longest side of a polygon is smaller than the sum of its other sides.

Conversely, if you have k (k >= 3) positive real numbers a1, a2, a3,
..., ak where a1 <= a2 <= a3 <= ... <= ak and a1 + a2 + a3 + ... +
ak-1 > ak, then there always exists a polygon with k sides whose
lengths are a1, a2, a3, ..., ak.

The perimeter of a polygon is the sum of lengths of its sides.

Return the largest possible perimeter of a polygon whose sides can be
formed from nums, or -1 if it is not possible to create a polygon.

APPROACH:
Sort the array in increasing order. Then loop the array while saving
the total sum so far and find the largest number that is smaller than
the total sum so far before that number.
*/


public class Solution
{
  public long LargestPerimeter(int[] nums)
  {
    Array.Sort(nums);
    long largestPerimeter = -1;
    long tempSum = 0;
    foreach (int num in nums)
    {
      if (num < tempSum)
      {
        largestPerimeter = tempSum + num;
      }
      tempSum += num;
    }
    return largestPerimeter;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
