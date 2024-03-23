/*
DIFFICULTY: Easy
QUESTION: 461. Hamming Distance

The Hamming distance between two integers is the number of positions at which
the corresponding bits are different.

Given two integers x and y, return the Hamming distance between them.

INTUITION/APPROACH:
Take xor of the integers, turn into a binary number (string) and count ones.
*/

using Utilities;

public class Solution
{
  public int HammingDistance(int x, int y)
  {
    return Convert.ToString(x ^ y, 2).Count(c => c == '1');
  }

  public static void Main()
  {
  }
}
