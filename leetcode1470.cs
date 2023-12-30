using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1470. Shuffle the Array

Given the array nums consisting of 2n elements in the form
[x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].

APPROACH:
With two index "pointers" one pointing to x values and one pointing to y values
populate a new array while moving pointers forward.
*/

public class Solution
{

  public int[] Shuffle(int[] nums, int n)
  {
    int[] result = new int[nums.Length];
    int pointer1 = 0;
    int pointer2 = n;
    while (pointer1 < n)
    {
      result[pointer1 * 2] = nums[pointer1];
      result[pointer1 * 2 + 1] = nums[pointer2];
      pointer1++;
      pointer2++;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
