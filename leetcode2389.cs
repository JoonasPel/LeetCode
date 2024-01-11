using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2389. Longest Subsequence With Limited Sum

You are given an integer array nums of length n, and an integer array queries
of length m.

Return an array answer of length m where answer[i] is the maximum size of a
subsequence that you can take from nums such that the sum of its elements is
less than or equal to queries[i].

A subsequence is an array that can be derived from another array by deleting
some or no elements without changing the order of the remaining elements.

Constraints:

    n == nums.length
    m == queries.length
    1 <= n, m <= 1000
    1 <= nums[i], queries[i] <= 106

APPROACH:
The Constraints say that the values in the arrs are max 1000, so we can create
a array of length 1001 and use it so that the value = index and
arr[index] = weight. Sum the weights to the correct index/value and then
create the result List from non-zero values in the array.
*/

public class Solution
{
  public int[] AnswerQueries(int[] nums, int[] queries)
  {
    Array.Sort(nums);
    int[] cumulativeSum = new int[nums.Length];
    int tempSum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      tempSum += nums[i];
      cumulativeSum[i] = tempSum;
    }
    int[] res = new int[queries.Length];
    for (int i = 0; i < queries.Length; i++)
    {
      int index = Array.BinarySearch(cumulativeSum, queries[i]);
      if (index >= 0)
      {
        res[i] = index + 1;
      }
      else
      {
        res[i] = ~index;
      }
    }
    return res;
  }
}
