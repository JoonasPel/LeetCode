/*
DIFFICULTY: Easy
QUESTION: 2651. Calculate Delayed Arrival Time

You are given a positive integer arrivalTime denoting the arrival time of a
train in hours, and another positive integer delayedTime denoting the amount of
delay in hours.

Return the time when the train will arrive at the station.

Note that the time in this problem is in 24-hours format.

INTUITION/APPROACH:
*/


public class Solution
{
  public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
  {
    TimeSpan arrival = new TimeSpan(hours: arrivalTime, 0, 0);
    TimeSpan actual = arrival.Add(new TimeSpan(hours: delayedTime, 0, 0));
    return actual.Hours;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.FindDelayedArrivalTime(13, 23));
  }
}
