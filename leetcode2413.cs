/*
DIFFICULTY: Easy
QUESTION: 2413. Smallest Even Multiple

DESCRIPTION:
Given a positive integer n, return the smallest positive integer that is a
multiple of both 2 and n. 

INTUITION/APPROACH:
If n is even, return n, otherwise return 2*n.
My approach checks if the last bit is one (is yes, num is odd) but I think the
language/compiler probably does it like that anyway, if writing num % 2 == 0.
*/


public class Solution
{
  public int SmallestEvenMultiple(int n)
  {
    return (n & 1) == 1 ? 2 * n : n;
    // return n % 2 != 0 ? n * 2 : n;
  }

  public static void Main()
  {
  }
}
