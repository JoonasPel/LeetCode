using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2656. Maximum Sum With Exactly K Elements

You are given a 0-indexed integer array nums and an integer k. Your task is to
perform the following operation exactly k times in order to maximize your score:

    Select an element m from nums.
    Remove the selected element m from the array.
    Add a new element with a value of m + 1 to the array.
    Increase your score by m.

Return the maximum score you can achieve after performing the operation exactly
k times.

APPROACH:
Answer is just the max value of nums arr k-times + the added values. Can be
calculated with simple average formula but For-loop would be fine too, because
the Max() method uses a loop anyway to find the max value from the array.
*/

public class Solution
{

  public int MaximizeSum(int[] nums, int k)
  {
    double addedNum = (double)(k - 1) / 2 * k;
    return nums.Max() * k + (int)addedNum;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
