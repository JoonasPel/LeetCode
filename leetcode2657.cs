/*
DIFFICULTY: Medium
QUESTION: 2657. Find the Prefix Common Array of Two Arrays

DESCRIPTION:
You are given two 0-indexed integer permutations A and B of length n.

A prefix common array of A and B is an array C such that C[i] is equal to the
count of numbers that are present at or before the index i in both A and B.

Return the prefix common array of A and B.

A sequence of n integers is called a permutation if it contains all integers
from 1 to n exactly once.

INTUITION/APPROACH:
Using Set to keep track of the found numbers. Because numbers in the arrays are
distinct, we can keep count of the common numbers found by these rules:
- If A[i] == B[i] a new common number is found.
- When adding a number to the Set, if it is already there (added by the other
array) we found a new common number.
*/

public class Solution
{
  public int[] FindThePrefixCommonArray(int[] A, int[] B)
  {
    HashSet<int> seen = new();
    int[] result = new int[A.Length];
    int common = 0;
    for (int i = 0; i < A.Length; i++)
    {
      if (A[i] == B[i])
      {
        seen.Add(A[i]);
        common++;
      }
      else
      {
        if (!seen.Add(A[i])) common++;
        if (!seen.Add(B[i])) common++;
      }
      result[i] = common;
    }
    return result;
  }

  public static void Main()
  {
  }
}
