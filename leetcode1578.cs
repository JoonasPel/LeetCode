using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1578. Minimum Time to Make Rope Colorful

Alice has n balloons arranged on a rope. You are given a 0-indexed string
colors where colors[i] is the color of the ith balloon.

Alice wants the rope to be colorful. She does not want two consecutive balloons
to be of the same color, so she asks Bob for help. Bob can remove some balloons
from the rope to make it colorful. You are given a 0-indexed integer array
neededTime where neededTime[i] is the time (in seconds) that Bob needs to
remove the ith balloon from the rope.

Return the minimum time Bob needs to make the rope colorful.

APPROACH:
Go through the colors and keep track of the total+max cost of consecutive same
colors and when encountering another color, "remove" all but 1 from the earlier
consecutive colors by increasing total usedTime by total cost - max cost. This
basically "removes" everything but the most expensive. Notice buffer at the end
also.
*/


public class Solution
{

  public int MinCost(string colors, int[] neededTime)
  {
    if (colors.Length < 2) return 0; // trivial case
    char earlierColor = colors[0];
    int usedTime = 0;
    int tempTotalTime = neededTime[0];
    int tempHighestTime = neededTime[0];
    for (int i = 1; i < colors.Length; i++)
    {
      if (colors[i] != earlierColor)
      {
        usedTime += tempTotalTime - tempHighestTime;
        tempHighestTime = tempTotalTime = neededTime[i];
        earlierColor = colors[i];
      }
      else
      {
        tempTotalTime += neededTime[i];
        tempHighestTime = Math.Max(tempHighestTime, neededTime[i]);
      }
    }
    // possible buffer
    if (colors[^1] == colors[^2])
    {
      usedTime += tempTotalTime - tempHighestTime;
    }
    return usedTime;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MinCost("abaac", new int[] { 1, 2, 3, 4, 5 }));
    Console.WriteLine(app.MinCost("abc", new int[] { 1, 2, 3 }));
    Console.WriteLine(app.MinCost("aabaa", new int[] { 1, 2, 3, 4, 1 }));
  }
}
