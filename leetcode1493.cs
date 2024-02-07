/*
DIFFICULTY: Medium
QUESTION: 1493. Longest Subarray of 1's After Deleting One Element

Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the
resulting array. Return 0 if there is no such subarray.

APPROACH:
Loop the numbers and keep count of the ones found before a SINGLE zero and then
sum that with the ones found after the single zero. If multiple zeroes next to
each other, the ones found before the zeroes dont count, because we can remove
only one zero.
If arr consists of only ones, we still need to remove one number, so a one.  
*/

public class Solution
{
  public int LongestSubarray(int[] nums)
  {
    int earlierLeftOnes = 0;
    int currentOnes = 0;
    int maxOnesSoFar = 0;
    bool zeroFound = false;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] == 1)
      {
        currentOnes++;
      }
      else
      {
        zeroFound = true;
        maxOnesSoFar = Math.Max(maxOnesSoFar, earlierLeftOnes + currentOnes);
        earlierLeftOnes = currentOnes;
        currentOnes = 0;
      }
    }
    maxOnesSoFar = Math.Max(maxOnesSoFar, earlierLeftOnes + currentOnes);
    if (!zeroFound)
    {
      maxOnesSoFar -= 1;
    }
    return maxOnesSoFar;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
