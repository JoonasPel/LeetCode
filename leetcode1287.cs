using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1287. Element Appearing More Than 25% In Sorted Array

Given an integer array sorted in non-decreasing order, there is
exactly one integer in the array that occurs more than 25% of the
time, return that integer.

APPROACH:
Array is sorted so the integer appearing more than 25% of times will
be repeated more than numbers length / 4 times, meaning we can loop
the numbers and check if the same number is still there 25% further in
the array.
*/


public class Solution
{
  public int FindSpecialInteger(int[] arr)
  {
    int threshold = arr.Length / 4;
    int index = 0;
    foreach (int number in arr)
    {
      if (number == arr[index + threshold])
      {
        return number;
      }
      index++;
    }
    return -1;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
