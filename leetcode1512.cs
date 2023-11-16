using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1512. Number of Good Pairs

Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

APPROACH:
Go through the array while saving the occurences count into a dictionary. Key
is the number and value is the count how many times it has been seen so far.
At every number check how many times this number has been seen before and add
that number to total good pairs found, because every earlier occurence is one
good pair.
*/

public class Solution
{

  public int NumIdenticalPairs(int[] nums)
  {
    Dictionary<int, int> occurences = new Dictionary<int, int>();
    int pairs = 0;
    int tempKey;
    for (int i = 0; i < nums.Length; i++)
    {
      tempKey = nums[i];
      if (occurences.TryGetValue(tempKey, out int value))
      {
        pairs += value;
        occurences[tempKey] += 1;
      }
      else occurences.Add(tempKey, 1);
    }
    return pairs;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
  }
}
