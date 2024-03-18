/*
DIFFICULTY: Easy
QUESTION: 349. Intersection of Two Arrays

Given two integer arrays nums1 and nums2, return an array of their
intersection. Each element in the result must be unique and you may return the
result in any order.

INTUITION/APPROACH:
*/


public class Solution
{

  public int[] Intersection(int[] nums1, int[] nums2)
  {
    return nums1.Intersect(nums2).ToArray();
  }

  public static void Main()
  {
  }
}

