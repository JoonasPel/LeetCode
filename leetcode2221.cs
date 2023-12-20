using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2221. Find Triangular Sum of an Array

You are given a 0-indexed integer array nums, where nums[i] is a digit between
0 and 9 (inclusive).

The triangular sum of nums is the value of the only element present in nums
after the following process terminates:

    1. Let nums comprise of n elements. If n == 1, end the process. Otherwise,
    create a new 0-indexed integer array newNums of length n - 1.
    2. For each index i, where 0 <= i < n - 1, assign the value of newNums[i]
    as (nums[i] + nums[i+1]) % 10, where % denotes modulo operator.
    3. Replace the array nums with newNums.
    4. Repeat the entire process starting from step 1.

Return the triangular sum of nums.

APPROACH:
Keep looping the array and creating new array until the new array size is 1.
*/


public class Solution
{

  public int TriangularSum(int[] nums)
  {
    int[] currentNums = nums;
    while (currentNums.Length > 1)
    {
      int[] newNums = new int[currentNums.Length - 1];
      for (int i = 0; i < currentNums.Length - 1; i++)
      {
        newNums[i] = (currentNums[i] + currentNums[i + 1]) % 10;
      }
      currentNums = newNums;
    }
    return currentNums[0];
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.TriangularSum(new int[] { 1, 2, 3, 4, 5 }));
  }
}
