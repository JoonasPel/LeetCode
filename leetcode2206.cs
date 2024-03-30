/*
DIFFICULTY: Easy
QUESTION: 2206. Divide Array Into Equal Pairs

DESCRIPTION:
You are given an integer array nums consisting of 2 * n integers.

You need to divide nums into n pairs such that:

    Each element belongs to exactly one pair.
    The elements present in a pair are equal.

Return true if nums can be divided into n pairs, otherwise return false.

INTUITION/APPROACH:
Go through the nums and save their frequency to an array and the number
of odd frequencies that exist currently. At the end if odd frequencies
existing is zero, we can make the pairs.
!! CONSTRAINTS define nums[i] in range [1,500] so "array trick" can be
used instead of a dictionary.
*/


public class Solution
{
  public bool DivideArray(int[] nums)
  {
    int oddCounter = 0;
    int[] freqs = new int[501];
    foreach (int num in nums)
    {
      if (++freqs[num] % 2 != 0)
      {
        oddCounter++;
      }
      else
      {
        oddCounter--;
      }
    }
    return oddCounter == 0;
  }

  public static void Main()
  {
  }
}
