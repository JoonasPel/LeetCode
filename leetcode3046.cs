/*
DIFFICULTY: Easy
QUESTION: 3046. Split the Array

DESCRIPTION:
You are given an integer array nums of even length. You have to split the array
into two parts nums1 and nums2 such that:

    nums1.length == nums2.length == nums.length / 2.
    nums1 should contain distinct elements.
    nums2 should also contain distinct elements.

Return true if it is possible to split the array, and false otherwise.

INTUITION/APPROACH:
The split can be done if the nums array doesn't have any number with frequency
higher than 2
*/


public class Solution
{
  public bool IsPossibleToSplit(int[] nums)
  {
    Dictionary<int, int> freqs = new();
    foreach (int num in nums)
    {
      freqs.TryGetValue(num, out int freq);
      if (freq == 2) return false;
      freqs[num] = freq + 1;
    }
    return true;
  }

  public static void Main()
  {
  }
}
