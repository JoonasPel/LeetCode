/*
DIFFICULTY: Medium
QUESTION: 2958. Length of Longest Subarray With at Most K Frequency

DESCRIPTION:
You are given an integer array nums and an integer k.
The frequency of an element x is the number of times it occurs in an
array.
An array is called good if the frequency of each element in this array
is less than or equal to k.
Return the length of the longest good subarray of nums.
A subarray is a contiguous non-empty sequence of elements within an array.

INTUITION/APPROACH:
Save the frequencies of the current subarray to dictionary. Increase
the subarray by moving the right idx pointer one step to right, check
the dictionary and if subarray is still valid, save its length and repeat.
If subarray becomes "invalid", move the left idx pointer to right 
(while updating the dictionary) until the subarray is valid again.
*/


public class Solution
{
  public int MaxSubarrayLength(int[] nums, int k)
  {
    Dictionary<int, int> freqs = new();
    int leftPtr = 0;
    int rightPtr = -1;
    int longestSubarray = 0;
    while (rightPtr < nums.Length - 1)
    {
      rightPtr++;
      freqs.TryGetValue(nums[rightPtr], out int freq);
      freqs[nums[rightPtr]] = freq + 1;
      if (freq == k)
      {
        while (leftPtr <= rightPtr)
        {
          freqs.TryGetValue(nums[leftPtr], out int freq1);
          freqs[nums[leftPtr]] = freq1 - 1;
          leftPtr++;
          if (nums[leftPtr - 1] == nums[rightPtr]) break;
        }
      }
      longestSubarray = Math.Max(longestSubarray, rightPtr - leftPtr + 1);
    }
    return longestSubarray;
  }

  public static void Main()
  {
  }
}
