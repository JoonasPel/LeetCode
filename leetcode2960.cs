using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2960. Count Tested Devices After Test Operations

You are given a 0-indexed integer array batteryPercentages having
length n, denoting the battery percentages of n 0-indexed devices.

Your task is to test each device i in order from 0 to n - 1, by
performing the following test operations:

    If batteryPercentages[i] is greater than 0:
        Increment the count of tested devices.
        Decrease the battery percentage of all devices with indices j
        in the range [i + 1, n - 1] by 1, ensuring their battery
        percentage never goes below 0, i.e, batteryPercentages[j] =
        max(0, batteryPercentages[j] - 1).
        Move to the next device.
    Otherwise, move to the next device without performing any test.

Return an integer denoting the number of devices that will be tested
after performing the test operations in order.

APPROACH:
Keep count how many decreases has happened while looping the array
and increase the tested devices counter if current device has more
than zero percentage after calculating original percentage - decreases
*/


public class Solution
{
  public int CountTestedDevices(int[] batteryPercentages)
  {
    int tested = 0;
    int decreased = 0;
    foreach (int battery in batteryPercentages)
    {
      if (battery - decreased > 0)
      {
        tested++;
        decreased++;
      }
    }
    return tested;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
