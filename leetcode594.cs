/*
DIFFICULTY: Easy
QUESTION: 594. Longest Harmonious Subsequence

DESCRIPTION:
We define a harmonious array as an array where the difference between its
maximum value and its minimum value is exactly 1.

Given an integer array nums, return the length of its longest harmonious
subsequence among all its possible subsequences.

A subsequence of array is a sequence that can be derived from the array by
deleting some or no elements without changing the order of the remaining
elements.

INTUITION/APPROACH:
Put nums and their freqs to sorted dictionary. Then go through the items
and if two adjacent numbers are harmonious (num1-num2==1), they can make a
harmonious subsequence. Sum their freqs and find the largest sum.
*/

public class Solution
{
  public int FindLHS(int[] nums)
  {
    SortedDictionary<int, int> freqs = new();
    foreach (int num in nums)
    {
      freqs.TryGetValue(num, out int count);
      freqs[num] = count + 1;
    }
    int maxSubseq = 0;
    (int earlierNum, int earlierCount) = freqs.First();
    foreach (var (number, count) in freqs.Skip(1))
    {
      if (number == earlierNum + 1)
      {
        maxSubseq = Math.Max(maxSubseq, count + earlierCount);
      }
      (earlierNum, earlierCount) = (number, count);
    }
    return maxSubseq;
  }

  public static void Main()
  {
  }
}
