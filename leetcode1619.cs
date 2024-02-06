/*
DIFFICULTY: Easy
QUESTION: 1619. Mean of Array After Removing Some Elements

Given an integer array arr, return the mean of the remaining integers after
removing the smallest 5% and the largest 5% of the elements.

Answers within 10-5 of the actual answer will be considered accepted.

Constraints:

    20 <= arr.length <= 1000
    arr.length is a multiple of 20.
    0 <= arr[i] <= 105

APPROACH:
Sort array and calculate average without the first and last 5%. Input is always
a multiple of 20 by the task definition.
*/

public class Solution
{
  public double TrimMean(int[] arr)
  {
    Array.Sort(arr);
    int startIdx = arr.Length / 20;
    int endIdx = (int)(arr.Length * 0.95);
    return arr[startIdx..endIdx].Average();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
