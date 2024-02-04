/*
DIFFICULTY: Medium
QUESTION: 2149. Rearrange Array Elements by Sign

You are given a 0-indexed integer array nums of even length consisting of an
equal number of positive and negative integers.

You should rearrange the elements of nums such that the modified array follows
the given conditions:

    Every consecutive pair of integers have opposite signs.
    For all integers with the same sign, the order in which they were present
    in nums is preserved.
    The rearranged array begins with a positive integer.

Return the modified array after rearranging the elements to satisfy the
aforementioned conditions.

APPROACH:
It is not O(n^2) even thou it has nested loops. So we are going through the
result array and finding correct numbers with two different index pointers in
the original nums array. One pointing to even numbers, one pointing to odd
numbers.
*/

public class Solution
{
  public int[] RearrangeArray(int[] nums)
  {
    int[] result = new int[nums.Length];
    int positivePointer = 0;
    int negativePointer = 0;
    for (int i = 0; i < result.Length; i++)
    {
      if (i % 2 == 0)
      {
        while (nums[positivePointer] < 0)
        {
          positivePointer++;
        }
        result[i] = nums[positivePointer];
        positivePointer++;
      }
      else
      {
        while (nums[negativePointer] > 0)
        {
          negativePointer++;
        }
        result[i] = nums[negativePointer];
        negativePointer++;
      }
    }
    return result;
  }

  public static void Main()
  {
    int[] nums = [3, 1, -2, -5, 2, -4];
    Solution app = new Solution();
    int[] result = app.RearrangeArray(nums);
    //Utilities.ArrayUtils.PrintEnumerable(result);
  }
}
