using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2970. Count the Number of Incremovable Subarrays I
Q1 of Biweekly Contest 120. I did this during the contest.

You are given a 0-indexed array of positive integers nums.

A subarray of nums is called incremovable if nums becomes strictly
increasing on removing the subarray. For example, the subarray [3, 4]
is an incremovable subarray of [5, 3, 4, 6, 7] because removing this
subarray changes the array [5, 3, 4, 6, 7] to [5, 6, 7] which is
strictly increasing.

Return the total number of incremovable subarrays of nums.

Note that an empty array is considered strictly increasing.

A subarray is a contiguous non-empty sequence of elements within an
array.

APPROACH:
n^3 brute force with sliding window, slide all window sizes from 1
to nums.Length in all positions and check if the part left outside
the window is in strictly increasing order.
Was "fast" enough to get Accepted.
*/


public class Solution
{
  public int IncremovableSubarrayCount(int[] nums)
  {
    int result = 0;
    for (int subarraySize = 1; subarraySize <= nums.Length; subarraySize++)
    {
      int subArrayStart = 0;
      while (subArrayStart + subarraySize <= nums.Length)
      {
        List<int> numbers = new List<int>(nums);
        numbers.RemoveRange(subArrayStart, subarraySize);
        if (isStrictlyIncreasing(numbers)) result++;
        subArrayStart++;
      }
    }
    return result;

    bool isStrictlyIncreasing(List<int> nums)
    {
      int earlier = int.MinValue;
      foreach (int num in nums)
      {
        if (num <= earlier)
        {
          return false;
        }
        earlier = num;
      }
      return true;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.IncremovableSubarrayCount(new int[] { 1, 2, 3, 4 }));
    Console.WriteLine(app.IncremovableSubarrayCount(new int[] { 6, 5, 7, 8 }));
    Console.WriteLine(app.IncremovableSubarrayCount(new int[] { 8, 7, 6, 6 }));
  }
}
