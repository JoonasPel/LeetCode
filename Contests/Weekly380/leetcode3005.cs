using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 3005. Count Elements With Maximum Frequency
Q1 of Weekly Contest 380. I did this during the contest.

You are given an array nums consisting of positive integers.

Return the total frequencies of elements in nums such that those elements all
have the maximum frequency.

The frequency of an element is the number of occurrences of that element in the
array.

APPROACH:
Loop the numbers and save counts to a dictionary. And also the highest freq
found so far. Afterwards get the sum of all counts that are same as the
highest freq found.
*/

public class Solution
{
  public int MaxFrequencyElements(int[] nums)
  {
    var occurences = new Dictionary<int, int>();
    int maxFrequency = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      occurences.TryGetValue(nums[i], out int count);
      occurences[nums[i]] = count + 1;
      maxFrequency = Math.Max(maxFrequency, count + 1);
    }
    int result = 0;
    foreach (var num in occurences)
    {
      if (num.Value == maxFrequency)
      {
        result += num.Value;
      }
    }
    return result;
  }
}