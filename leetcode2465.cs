using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2465. Number of Distinct Averages

You are given a 0-indexed integer array nums of even length.

As long as nums is not empty, you must repetitively:

    Find the minimum number in nums and remove it.
    Find the maximum number in nums and remove it.
    Calculate the average of the two removed numbers.

The average of two numbers a and b is (a + b) / 2.

    For example, the average of 2 and 3 is (2 + 3) / 2 = 2.5.

Return the number of distinct averages calculated using the above process.

Note that when there is a tie for a minimum or maximum number,
any can be removed.

APPROACH:
Avg is not needed to be calculated because divider is always 2, so just sum can
be used. Sort the array and then with two "pointers" begin from left and right
of array and start adding the sum of the current smallest and largest to Set
and at the end return Set.Count, which is the count of unique sums = averages.
*/

public class Program
{

  // remove static for leetcode
  public static int DistinctAverages(int[] nums)
  {
    Array.Sort(nums);
    HashSet<int> distinctSums = new HashSet<int>();
    int smallestIndex = 0;
    int largestIndex = nums.Length - 1;
    while (smallestIndex <= largestIndex)
    {
      distinctSums.Add(nums[smallestIndex] + nums[largestIndex]);
      smallestIndex++;
      largestIndex--;
    }
    return distinctSums.Count;
  }

  public static void Main()
  {
    int[] nums = new int[] { 4, 1, 4, 0, 3, 5 };
    DistinctAverages(nums);
  }
}
