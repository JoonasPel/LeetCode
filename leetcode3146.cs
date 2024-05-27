/*
DIFFICULTY: Easy
QUESTION: 3146. Permutation Difference between Two Strings

DESCRIPTION:
You are given two strings s and t such that every character occurs at most once
in s and t is a permutation of s.

The permutation difference between s and t is defined as the sum of the
absolute difference between the index of the occurrence of each character in s
and the index of the occurrence of the same character in t.

Return the permutation difference between s and t.

INTUITION/APPROACH:
*/

public class Solution
{
  public int FindPermutationDifference(string s, string t)
  {
    Dictionary<char, int> occurIndex = new();
    for (int i = 0; i < t.Length; i++)
    {
      occurIndex[t[i]] = i;
    }
    int permDiff = 0;
    for (int i = 0; i < s.Length; i++)
    {
      permDiff += Math.Abs(i - occurIndex[s[i]]);
    }
    return permDiff;
  }

  public static void Main()
  {
  }
}
