/*
DIFFICULTY: Easy
QUESTION: 1403. Minimum Subsequence in Non-Increasing Order

Given the array nums, obtain a subsequence of the array whose sum of elements
is strictly greater than the sum of the non included elements in such
subsequence. 

If there are multiple solutions, return the subsequence with minimum size and
if there still exist multiple solutions, return the subsequence with the
maximum total sum of all its elements. A subsequence of an array can be
obtained by erasing some (possibly zero) elements from the array. 

Note that the solution with the given constraints is guaranteed to be unique.
Also return the answer sorted in non-increasing order.

INTUITION/APPROACH:
Sort array descending, get total sum and then beginning from the largest numbers
find as many numbers as needed to get bigger sum than the numbers not included.
*/


public class Solution
{
  public IList<int> MinSubsequence(int[] nums)
  {
    Array.Sort(nums, (a, b) => b - a);
    int totalSum = nums.Sum();
    int tempSum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      tempSum += nums[i];
      if (tempSum > totalSum / 2)
      {
        return nums[0..(i + 1)];
      }
    }
    return [];
  }

  public static void Main()
  {
  }
}
