using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2540. Minimum Common Value

Given two integer arrays nums1 and nums2, sorted in non-decreasing order,
return the minimum integer common to both arrays. If there is no common integer
amongst nums1 and nums2, return -1.

Note that an integer is said to be common to nums1 and nums2 if both arrays
have at least one occurrence of that integer.

APPROACH:
Go through the arrays with two index "pointers" and always increase the pointer
that points to the lower value at the time, and when both pointers point to an
equal value, return that value. 
*/


public class Solution
{

  public int GetCommon(int[] nums1, int[] nums2)
  {
    int ptr1 = 0;
    int ptr2 = 0;
    while (ptr1 < nums1.Length && ptr2 < nums2.Length)
    {
      if (nums1[ptr1] == nums2[ptr2])
      {
        return nums1[ptr1];
      }
      else if (nums1[ptr1] < nums2[ptr2])
      {
        ptr1++;
      }
      else
      {
        ptr2++;
      }
    }
    return -1;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
