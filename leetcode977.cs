/*
DIFFICULTY: Easy
QUESTION: 977. Squares of a Sorted Array

DESCRIPTION:
Given an integer array nums sorted in non-decreasing order, return
an array of the squares of each number sorted in non-decreasing order.

INTUITION/APPROACH:
The original array ABS reduces from both ends towards the middle,
so we can insert the squares into result array without sorting by
using two pointers from left and right and check which one is bigger,
then insert square of that into result array (starting from end) and
move the used pointer one step inner.
*/


public class Solution
{
  public int[] SortedSquares(int[] nums)
  {
    int leftPtr = 0;
    int rightPtr = nums.Length - 1;
    int[] result = new int[nums.Length];
    int resultPtr = result.Length - 1;
    while (resultPtr >= 0)
    {
      if (Math.Abs(nums[leftPtr]) > Math.Abs(nums[rightPtr]))
      {
        result[resultPtr] = (int)Math.Pow(nums[leftPtr], 2);
        leftPtr++;
      }
      else
      {
        result[resultPtr] = (int)Math.Pow(nums[rightPtr], 2);
        rightPtr--;
      }
      resultPtr--;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new();
    app.SortedSquares([-4, -1, 0, 3, 10]);
  }
}
