/*
DIFFICULTY: Easy
QUESTION: 2395. Find Subarrays With Equal Sum

Given a 0-indexed integer array nums, determine whether there exist two
subarrays of length 2 with equal sum. Note that the two subarrays must begin at
different indices.

Return true if these subarrays exist, and false otherwise.

A subarray is a contiguous non-empty sequence of elements within an array.

INTUITION/APPROACH:
Save sums to a Set and return true if a duplicate is found.
Minimized code for fun
*/

public class Solution
{
  public bool FindSubarrays(int[] n)
  {
    HashSet<int>s=[];for(int i=0;i<n.Length-1;i++)if(!s.Add(n[i]+n[i+1]))return true;return false;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
