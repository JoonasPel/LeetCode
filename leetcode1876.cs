/*
DIFFICULTY: Easy
QUESTION: 1876. Substrings of Size Three with Distinct Characters

DESCRIPTION:
A string is good if there are no repeated characters.

Given a string s​​​​​, return the number of good substrings of length three in s​​​​​​.

Note that if there are multiple occurrences of the same substring, every
occurrence should be counted.

A substring is a contiguous sequence of characters in a string.

INTUITION/APPROACH:
Go through the string and always check if the current char + two nexts are
different, and then increase result number
*/


public class Solution
{
  public int CountGoodSubstrings(string s)
  {
    int result = 0;
    for (int i = 0; i < s.Length - 2; i++)
    {
      if (s[i] != s[i + 1] && s[i + 1] != s[i + 2] && s[i] != s[i + 2])
      {
        result++;
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
