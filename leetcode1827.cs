/*
DIFFICULTY: Easy
QUESTION: 1827. Minimum Operations to Make the Array Increasing

You are given an integer array nums (0-indexed). In one operation, you can
choose an element of the array and increment it by 1.

    For example, if nums = [1,2,3], you can choose to increment nums[1] to make
    nums = [1,3,3].

Return the minimum number of operations needed to make nums strictly increasing.

An array nums is strictly increasing if nums[i] < nums[i+1] for all
0 <= i < nums.length - 1. An array of length 1 is trivially strictly increasing.

INTUITION/APPROACH:
Next number needs to be one bigger than earlier. Keep count of total increase
and the new value of the earlier after increase.
*/


public class Solution
{
  public int MinOperations(int[] nums)
  {
    int result = 0;
    int earlier = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
      int diff = nums[i] > earlier ? 0 : earlier - nums[i] + 1;
      result += diff;
      earlier = nums[i] + diff;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new();
  }
}
