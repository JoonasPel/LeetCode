using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2859. Sum of Values at Indices With K Set Bits

You are given a 0-indexed integer array nums and an integer k.

Return an integer that denotes the sum of elements in nums whose corresponding
indices have exactly k set bits in their binary representation.

The set bits in an integer are the 1's present when it is written in binary.

    For example, the binary representation of 21 is 10101, which has 3 set bits.

APPROACH:
Loop through the numbers and add the number to the sum if its index has k set
bits after turning it into binary number.
*/

public class Solution
{

  public int SumIndicesWithKSetBits(IList<int> nums, int k)
  {
    int sum = 0;
    for (int i = 0; i < nums.Count; i++)
    {
      string binary = Convert.ToString(i, 2);
      int count = binary.Count(c => c == '1');
      if (count == k)
      {
        sum += nums[i];
      }
    }
    return sum;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
