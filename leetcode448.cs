/*
DIFFICULTY: Easy
QUESTION: 448. Find All Numbers Disappeared in an Array

Given an array nums of n integers where nums[i] is in the range [1, n],
return an array of all the integers in the range [1, n] that do not appear in
nums.

INTUITION/APPROACH:
Make a new array where index corresponds to the number in nums. Change the num
in new array to zero, if it is found in nums. Afterwards return all numbers
that are still zero.
*/

public class Solution
{
  public IList<int> FindDisappearedNumbers(int[] nums)
  {
    int[] temp = new int[nums.Length];
    foreach (int num in nums)
    {
      temp[num - 1] = 1;
    }
    IList<int> result = new List<int>();
    for (int i = 0; i < temp.Length; i++)
    {
      if (temp[i] == 0)
      {
        result.Add(i + 1);
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
