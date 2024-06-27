/*
DIFFICULTY: Easy
QUESTION: 2341. Maximum Number of Pairs in Array

DESCRIPTION:
You are given a 0-indexed integer array nums. In one operation, you may do the
following:

    Choose two integers in nums that are equal.
    Remove both integers from nums, forming a pair.

The operation is done on nums as many times as possible.

Return a 0-indexed integer array answer of size 2 where answer[0] is the number
of pairs that are formed and answer[1] is the number of leftover integers in
nums after doing the operation as many times as possible.

INTUITION/APPROACH:
Constraint 0 <= nums[i] <= 100 means that a boolean array can be used instead
of a dictionary to keep track of occurences. 

TIME COMPLEXITY: O(n)

THOUGHTS:
*/

public class Solution
{
  public int[] NumberOfPairs(int[] nums)
  {
    bool[] occurences = new bool[101];
    int pairs = 0;
    foreach (int num in nums)
    {
      if (occurences[num]) pairs++;
      occurences[num] = !occurences[num];
    }
    return [pairs, nums.Length - pairs * 2];
  }

  public static void Main()
  {
  }
}
