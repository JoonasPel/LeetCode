/*
DIFFICULTY: Easy
QUESTION: 2956. Find Common Elements Between Two Arrays

You are given two 0-indexed integer arrays nums1 and nums2 of sizes n and m,
respectively.

Consider calculating the following values:

    The number of indices i such that 0 <= i < n and nums1[i] occurs at least
    once in nums2.
    The number of indices i such that 0 <= i < m and nums2[i] occurs at least
    once in nums1.

Return an integer array answer of size 2 containing the two values in the above
order.

Constraints:

    n == nums1.length
    m == nums2.length
    1 <= n, m <= 100
    1 <= nums1[i], nums2[i] <= 100


INTUITION/APPROACH:
Use array as a fast Set because we can exploit constraints. Get occurences of
numbers in nums1 and then go throug the nums2 array and check the commons.
Mark the number in nums1 as -1 if it has already been accounted to the res[0].
*/

public class Solution
{

  public int[] FindIntersectionValues(int[] nums1, int[] nums2)
  {
    int[] occursInNums1 = new int[101];
    for (int i = 0; i < nums1.Length; i++)
    {
      occursInNums1[nums1[i]]++;
    }
    int[] result = new int[] { 0, 0 };
    foreach (int num in nums2)
    {
      if (occursInNums1[num] != 0)
      {
        result[1]++;
        if (occursInNums1[num] != -1)
        {
          result[0] += occursInNums1[num];
          occursInNums1[num] = -1;
        }
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new();
    var res = app.FindIntersectionValues(
      new int[] { 4, 3, 2, 3, 1 }, new int[] { 2, 2, 5, 2, 3, 6 });
    Console.WriteLine($"{res[0]}, {res[1]}");
  }
}
