/*
DIFFICULTY: Easy
QUESTION: 2864. Maximum Odd Binary Number

DESCRIPTION:
You are given a binary string s that contains at least one '1'.

You have to rearrange the bits in such a way that the resulting binary number
is the maximum odd binary number that can be created from this combination.

Return a string representing the maximum odd binary number that can be created
from the given combination.

Note that the resulting string can have leading zeros.

INTUITION/APPROACH:
Calculate ones. Insert as many ones as possible to beginning, then all zeros,
then single one as the last char.
*/

public class Solution
{
  public string MaximumOddBinaryNumber(string s)
  {
    int ones = s.Count(c => c == '1');
    if (ones == 0) return s;
    return new string('1', ones - 1) + new string('0', s.Length - ones) + '1';
  }

  public static void Main()
  {
  }
}
