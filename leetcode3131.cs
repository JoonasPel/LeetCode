/*
DIFFICULTY: Easy
QUESTION: 3131. Find the Integer Added to Array I

DESCRIPTION:
You are given two arrays of equal length, nums1 and nums2.

Each element in nums1 has been increased (or decreased in the case of negative)
by an integer, represented by the variable x.

As a result, nums1 becomes equal to nums2. Two arrays are considered equal when
they contain the same integers with the same frequencies.

Return the integer x.

INTUITION/APPROACH:
*/

public class Solution
{
  public int AddedInteger(int[] nums1, int[] nums2)
  {
    return nums2.Max() - nums1.Max();
  }
}
