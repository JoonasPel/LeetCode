/*
DIFFICULTY: Easy
QUESTION: 2670. Find the Distinct Difference Array

DESCRIPTION:
You are given a 0-indexed array nums of length n.

The distinct difference array of nums is an array diff of length n
such that diff[i] is equal to the number of distinct elements in the
suffix nums[i + 1, ..., n - 1] subtracted from the number of distinct
elements in the prefix nums[0, ..., i].

Return the distinct difference array of nums.

Note that nums[i, ..., j] denotes the subarray of nums starting at
index i and ending at index j inclusive. Particularly, if i > j then
nums[i, ..., j] denotes an empty subarray.

INTUITION/APPROACH:
Calculate distinct numbers count from left and right and save to
different arrays. Then use those to create the result array.
*/


public class Solution
{
  public int[] DistinctDifferenceArray(int[] nums)
  {
    if (nums.Length == 1) return new int[] { 1 };
    int[] leftDistincts = new int[nums.Length];
    HashSet<int> seen = new();
    int distinctCount = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (seen.Add(nums[i])) distinctCount++;
      leftDistincts[i] = distinctCount;
    }
    int[] rightDistincts = new int[nums.Length];
    seen.Clear();
    distinctCount = 0;
    for (int i = nums.Length - 1; i >= 0; i--)
    {
      if (seen.Add(nums[i])) distinctCount++;
      rightDistincts[i] = distinctCount;
    }
    int[] result = new int[nums.Length];
    result[0] = 1 - rightDistincts[1];
    for (int i = 1; i < result.Length - 1; i++)
    {
      result[i] = leftDistincts[i] - rightDistincts[i + 1];
    }
    result[^1] = leftDistincts[^1];
    return result;
  }

  public static void Main()
  {
  }
}
