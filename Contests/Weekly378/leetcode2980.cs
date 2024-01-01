using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2980. Check if Bitwise OR Has Trailing Zeros
Q1 of Weekly Contest 378. I did this during the contest.

You are given an array of positive integers nums.

You have to check if it is possible to select two or more elements in the array
such that the bitwise OR of the selected elements has at least one trailing
zero in its binary representation.

For example, the binary representation of 5, which is "101", does not have any
trailing zeros, whereas the binary representation of 4, which is "100", has two
trailing zeros.

Return true if it is possible to select two or more elements whose bitwise OR
has trailing zeros, return false otherwise.

APPROACH:
Even numbers have at least one trailing zero in binary so we basically just
need to check if there is at least 2 even numbers in the nums array. If yes,
then it is possible to take two even numbers and bitwise OR of them will have
also at least one trailing zero.
*/

public class Solution
{

  public bool HasTrailingZeros(int[] nums)
  {
    int evenCount = 0;
    foreach (int num in nums)
    {
      if (num % 2 == 0)
        evenCount++;
      if (evenCount >= 2)
        return true;
    }
    return false;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.HasTrailingZeros(new int[] { 1, 2, 3, 4, 5 }));
    Console.WriteLine(app.HasTrailingZeros(new int[] { 2, 4, 8, 16 }));
    Console.WriteLine(app.HasTrailingZeros(new int[] { 1, 3, 5, 7, 9 }));

  }
}
