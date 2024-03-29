/*
DIFFICULTY: Easy
QUESTION: 2848. Points That Intersect With Cars

DESCRIPTION:
You are given a 0-indexed 2D integer array nums representing the
coordinates of the cars parking on a number line. For any index i,
nums[i] = [starti, endi] where starti is the starting point of the ith
car and endi is the ending point of the ith car.

Return the number of integer points on the line that are covered with
any part of a car.

INTUITION/APPROACH:
Save every used spot to boolean array and keep count of the spots used.
For example if the points are [1,5], go through all numbers 1-5.
*/


public class Solution
{
  public int NumberOfPoints(IList<IList<int>> nums)
  {
    bool[] spotInUse = new bool[101];
    int totalSpots = 0;
    foreach (IList<int> item in nums)
    {
      for (int i = item[0]; i <= item[1]; i++)
      {
        if (spotInUse[i] == false)
        {
          spotInUse[i] = true;
          totalSpots++;
        }
      }
    }
    return totalSpots;
  }

  public static void Main()
  {
  }
}
