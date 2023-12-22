using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1207. Unique Number of Occurrences

Given an array of integers arr, return true if the number of
occurrences of each value in the array is unique or false otherwise.

APPROACH:
Loop the array and save number occurences to a dictionary. Then
loop the dictionary and check that all occurences are unique. Latter
is done by saving the count to an array as a index.
Same count => same index => not unique. This is faster than Set.
*/


public class Solution
{

  public bool UniqueOccurrences(int[] arr)
  {
    Dictionary<int, int> occurences = new Dictionary<int, int>();
    foreach (int num in arr)
    {
      occurences.TryGetValue(num, out int occurenceCount);
      occurences[num] = occurenceCount + 1;
    }
    int[] counts = new int[arr.Length + 1];
    foreach (var item in occurences)
    {
      if (counts[item.Value] != 0)
      {
        return false;
      }
      else
      {
        counts[item.Value] = 1;
      }
    }
    return true;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
