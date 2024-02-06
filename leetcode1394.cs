/*
DIFFICULTY: Easy
QUESTION: 1394. Find Lucky Integer in an Array

Given an array of integers arr, a lucky integer is an integer that has a
frequency in the array equal to its value.

Return the largest lucky integer in the array. If there is no lucky integer
return -1.

APPROACH:
Save frequencies to a dictionary and then find the largest lucky from there.
So two O(n) operations, where n = arr.Length
*/

public class Solution
{
  public int FindLucky(int[] arr)
  {
    Dictionary<int, int> frequencies = new();
    for (int i = 0; i < arr.Length; i++)
    {
      frequencies.TryGetValue(arr[i], out int freq);
      frequencies[arr[i]] = freq + 1;
    }
    int largestLucky = -1;
    foreach (KeyValuePair<int, int> number in frequencies)
    {
      if (number.Key == number.Value)
      {
        largestLucky = Math.Max(largestLucky, number.Value);
      }
    }
    return largestLucky;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
