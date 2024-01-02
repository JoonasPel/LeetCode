using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2610. Convert an Array Into a 2D Array With Conditions

You are given an integer array nums. You need to create a 2D array from nums
satisfying the following conditions:

    The 2D array should contain only the elements of the array nums.
    Each row in the 2D array contains distinct integers.
    The number of rows in the 2D array should be minimal.

Return the resulting array. If there are multiple answers, return any of them.

Note that the 2D array can have a different number of elements on each row.

APPROACH:
Sort the array and then insert values into matrix rows. If the number is not
the same as earlier one, keep adding to the same row. If the number is same,
add the number to the next row (and create one if needed). After finding a new
number again, start from row 0.
*/

public class Solution
{

  public IList<IList<int>> FindMatrix(int[] nums)
  {
    Array.Sort(nums);
    IList<IList<int>> result = new List<IList<int>>();
    int currentRow = 0;
    result.Add(new List<int>());
    result[currentRow].Add(nums[0]);
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] == nums[i - 1])
      {
        currentRow++;
        if (currentRow == result.Count)
        {
          result.Add(new List<int>());
        }
        result[currentRow].Add(nums[i]);
      }
      else
      {
        currentRow = 0;
        result[currentRow].Add(nums[i]);
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    var matrix = app.FindMatrix(new int[] { 1, 3, 4, 1, 2, 3, 1, 1, 1, 3, 3 });
    foreach (var row in matrix)
    {
      Console.WriteLine($"[{string.Join(',', row)}]");
    }
  }
}
