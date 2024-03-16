/*
DIFFICULTY: Easy
QUESTION: 1450. Number of Students Doing Homework at a Given Time

Given two integer arrays startTime and endTime and given an integer queryTime.

The ith student started doing their homework at the time startTime[i] and
finished it at time endTime[i].

Return the number of students doing their homework at time queryTime. More
formally, return the number of students where queryTime lays in the interval
[startTime[i], endTime[i]] inclusive.

INTUITION/APPROACH:
*/

public class Solution
{
  public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
  {
    int result = 0;
    for (int i = 0; i < startTime.Length; i++)
    {
      if (startTime[i] <= queryTime && endTime[i] >= queryTime)
      {
        result++;
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
