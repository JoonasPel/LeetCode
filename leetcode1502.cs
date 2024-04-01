/*
DIFFICULTY: Easy
QUESTION: 1502. Can Make Arithmetic Progression From Sequence

DESCRIPTION:
A sequence of numbers is called an arithmetic progression if the
difference between any two consecutive elements is the same.

Given an array of numbers arr, return true if the array can be
rearranged to form an arithmetic progression. Otherwise, return false.

INTUITION/APPROACH:

*/


public class Solution
{
  public bool CanMakeArithmeticProgression(int[] arr)
  {
    if (arr.Length <= 2) return true;
    Array.Sort(arr);
    int step = arr[0] - arr[1];
    for (int i = 1; i < arr.Length - 1;)
    {
      if (arr[i] - arr[++i] != step) return false;
    }
    return true;
  }

  public static void Main()
  {
  }
}
