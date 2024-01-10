using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 3002. Maximum Size of a Set After Removals
Q3 of Weekly Contest 379. I did this during the contest.

You are given two 0-indexed integer arrays nums1 and nums2 of even length n.

You must remove n / 2 elements from nums1 and n / 2 elements from nums2.After
the removals, you insert the remaining elements of nums1 and nums2 into a set s

Return the maximum possible size of the set s.

APPROACH:
Step 1: Find the numbers that are common to nums1 and nums2.

Step 2. From both arrays, find unique numbers. Unique numbers are numbers that
are not common and those numbers are counted only once. Unique numbers are
numbers that will be in the result Set, but only a maximum of
nums1/2.Length / 2 of them can be taken, because we need to remove half of the
values from both arrays.

Step 3. We check if there is still room to take more numbers. This happens if
we found less than nums1/2.Length / 2 unique numbers from one or both arrays.
If there is room, we take the commons values too. If this total sum now happens
to be larger than half of both arrays summed up, we only return the latter
because that is the "hard" cap.
*/

public class Solution
{

  public int MaximumSetSize(int[] nums1, int[] nums2)
  {
    HashSet<int> nums1Set = new HashSet<int>(nums1);
    HashSet<int> nums2Set = new HashSet<int>(nums2);
    nums1Set.IntersectWith(nums2Set);
    int valid1 = 0;
    HashSet<int> seen1 = new HashSet<int>();
    foreach (int num in nums1)
    {
      if (!nums1Set.Contains(num) && !seen1.Contains(num))
      {
        valid1++;
      }
      seen1.Add(num);
    }
    int valid2 = 0;
    HashSet<int> seen2 = new HashSet<int>();
    foreach (int num in nums2)
    {
      if (!nums1Set.Contains(num) && !seen2.Contains(num))
      {
        valid2++;
      }
      seen2.Add(num);
    }
    int a = Math.Min(valid1, nums1.Length / 2);
    int b = Math.Min(valid2, nums2.Length / 2);
    int x = 0;
    if (a < nums1.Length / 2 || b < nums2.Length / 2)
    {
      x = nums1Set.Count;
    }
    if (a + b + x < (nums1.Length / 2 + nums2.Length / 2)) return a + b + x;
    return nums1.Length / 2 + nums2.Length / 2;
  }

  public static void Main()
  {
    Solution app = new Solution();
    //app.MaximumSetSize(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });
    Console.WriteLine(app.MaximumSetSize(new int[] { 1, 2, 1, 2 }, new int[] { 1, 1, 1, 1 }));
    Console.WriteLine(app.MaximumSetSize(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 3, 2, 3, 2, 3 }));
    Console.WriteLine(app.MaximumSetSize(new int[] { 1, 1, 2, 2, 3, 3 }, new int[] { 4, 4, 5, 5, 6, 6 }));
  }
}
