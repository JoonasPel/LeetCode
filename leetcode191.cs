/*
DIFFICULTY: Easy
QUESTION: 191. Number of 1 Bits

DESCRIPTION:
Write a function that takes the binary representation of a positive integer and
returns the number of set bits it has (also known as the Hamming weight).

INTUITION/APPROACH:
*/

public class Solution
{
  public int HammingWeight(int n)
  {
    return Convert.ToString(n, 2).Count(c => c == '1');
  }

  public static void Main()
  {
  }
}
