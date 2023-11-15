using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 922. Sort Array By Parity II

Given an array of integers nums, half of the integers in nums are odd,
and the other half are even.

Sort the array so that whenever nums[i] is odd, i is odd, and whenever nums[i]
is even, i is even.

Return any answer array that satisfies this condition.

APPROACH:
Create new array for the result and go through all numbers in original array
while with two pointers one pointing to even indexes and one to odd indexes
insert values from nums to result array depending if value is even or odd.
After inserting, increment the pointer index by 2 to point to next even or odd.
*/

public class Solution
{

  public int[] SortArrayByParityII(int[] nums)
  {
    int[] res = new int[nums.Length];
    int evenPtrIdx = 0;
    int oddPtrIdx = 1;
    foreach (int num in nums)
    {
      if (num % 2 == 0)
      {
        res[evenPtrIdx] = num;
        evenPtrIdx += 2;
      }
      else
      {
        res[oddPtrIdx] = num;
        oddPtrIdx += 2;
      }
    }
    return res;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[] nums = new int[] { 4, 2, 5, 7 };
    app.SortArrayByParityII(nums);
    foreach (var num in nums) Console.WriteLine(num);
  }

}
