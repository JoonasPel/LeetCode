using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1732. Find the Highest Altitude

There is a biker going on a road trip. The road trip consists of n + 1 points
at different altitudes. The biker starts his trip on point 0 with altitude
equal 0.

You are given an integer array gain of length n where gain[i] is the net gain
in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest
altitude of a point.

APPROACH:
Go through the gains while keeping track of the current altitude and save the
max altitude.
*/

public class Solution
{

  public int LargestAltitude(int[] gain)
  {
    int currentAltitude = 0;
    int highestAltitude = 0;
    foreach (int localGain in gain)
    {
      currentAltitude += localGain;
      highestAltitude = Math.Max(highestAltitude, currentAltitude);
    }
    return highestAltitude;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
