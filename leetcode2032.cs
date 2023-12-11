using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2032. Two Out of Three

Given three integer arrays nums1, nums2, and nums3, return a distinct array
containing all the values that are present in at least two out of the three
arrays. You may return the values in any order. 

APPROACH:
Intersect the arrays to find numbers that are in two different arrays and then
add those numbers into a set to get only distinct numbers as result.
*/


public class Solution
{
  public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
  {
    int[] intersect12 = nums1.Intersect(nums2).ToArray();
    int[] intersect13 = nums1.Intersect(nums3).ToArray();
    int[] intersect23 = nums2.Intersect(nums3).ToArray();
    HashSet<int> distictNums = new HashSet<int>();
    foreach (int num in intersect12) distictNums.Add(num);
    foreach (int num in intersect13) distictNums.Add(num);
    foreach (int num in intersect23) distictNums.Add(num);
    return distictNums.ToList();
  }

  public static void Main()
  {
    Solution app = new Solution();
    var result = app.TwoOutOfThree(
      new int[] { 1, 2, 3, 3, 3, 2, 9 },
      new int[] { 6, 5, 3, 3, 2, 2, 9 },
      new int[] { 9, 9, 9, 9, 3, 3 }
    );
    foreach (var num in result) Console.WriteLine(num);
  }
}
