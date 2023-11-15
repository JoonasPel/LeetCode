using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1877. Minimize Maximum Pair Sum in Array

The pair sum of a pair (a,b) is equal to a + b. The maximum pair sum is
the largest pair sum in a list of pairs.

    For example, if we have pairs (1,5), (2,3), and (4,4),
    the maximum pair sum would be max(1+5, 2+3, 4+4) = max(6, 5, 8) = 8.

Given an array nums of even length n, pair up the elements of nums
into n / 2 pairs such that:

    Each element of nums is in exactly one pair, and
    The maximum pair sum is minimized.

Return the minimized maximum pair sum after optimally pairing up the elements.

APPROACH:
Sort the array and make pairs by summing together nums[i] and
nums[nums.Length - 1 - i]. So first and last, 2nd first and 2nd last. While
keeping track of the max pair encountered so far. This works because every time
a new pair is made, the max number available is used and it is paired with
the lowest number available, meaning we always try "minimize" the problem by
taking the most problematic number (the largest) and summing it with the
smallest number to minimize the sum we create. It is a bit "recursive" way of 
thinking it: Every iteration try to get rid of the biggest num with as low sum
as possible, then do it again.
*/

public class Solution
{

  public int MinPairSum(int[] nums)
  {
    Array.Sort(nums);
    int leftPtrIdx = 0;
    int rightPtrIdx = nums.Length - 1;
    int maxSoFar = int.MinValue;
    while (leftPtrIdx < rightPtrIdx)
    {
      maxSoFar = Math.Max(maxSoFar, nums[leftPtrIdx++] + nums[rightPtrIdx--]);
    }
    return maxSoFar;
  }

  public static void Main()
  {
  }

}
