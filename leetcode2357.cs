/*
DIFFICULTY: Easy
QUESTION: 2357. Make Array Zero by Subtracting Equal Amounts

DESCRIPTION:
You are given a non-negative integer array nums. In one operation, you must:

    Choose a positive integer x such that x is less than or equal to the
    smallest non-zero element in nums.
    Subtract x from every positive element in nums.

Return the minimum number of operations to make every element in nums equal to 0.

INTUITION/APPROACH:
Sort the array ascending. Then find as many numbers starting from the lowest
non-zero as needed to make the total subtractions enough to make the largest
number zero.
Remember to take into account that earlier numbers substract the next substractors,
too. So for example 1, 5, 7 has total substraction "power" of 1 + 4 + 2, because
the first subtraction makes the array [0, 4, 6], second one [0, 0, 2] and the
third one [0,0,0]
*/


public class Solution
{
  public int MinimumOperations(int[] nums)
  {
    Array.Sort(nums);
    int largest = nums[^1];
    int temp = 0;
    int operations = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] - temp == 0) continue;
      operations++;
      temp += nums[i] - temp;
      if (temp >= largest) return operations;
    }
    return operations;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.MinimumOperations([1, 5, 0, 3, 5]));
    Console.WriteLine(app.MinimumOperations([1, 5, 0, 3, 5, 4]));
    Console.WriteLine(app.MinimumOperations([1, 1, 1, 2, 2, 2, 3, 3]));
  }
}

