/*
DIFFICULTY: Easy
QUESTION: 1365. How Many Numbers Are Smaller Than the Current Number

DESCRIPTION:
Given the array nums, for each nums[i] find out how many numbers in the array
are smaller than it. That is, for each nums[i] you have to count the number of
valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.

INTUITION/APPROACH:
*/

public class Solution
{
  public int[] SmallerNumbersThanCurrent(int[] nums)
  {
    int[] original = new int[nums.Length];
    Array.Copy(nums, original, nums.Length);
    Array.Sort(nums);
    Dictionary<int, int> smallerCounts = new();
    smallerCounts[nums[0]] = 0;
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] > nums[i - 1])
      {
        smallerCounts[nums[i]] = i;
      }
    }
    for (int i = 0; i < nums.Length; i++)
    {
      original[i] = smallerCounts[original[i]];
    }
    return original;
  }

  public static void Main()
  {
    Solution app = new();
    app.SmallerNumbersThanCurrent([8, 1, 2, 2, 3]);
  }
}
