using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1528. Shuffle String

You are given a string s and an integer array indices of the same length.
The string s will be shuffled such that the character at the ith position moves
to indices[i] in the shuffled string.

Return the shuffled string.

APPROACH:
Go through the string and indices and put every char to the correct spot in a
char array that represents the result.
*/


public class Solution
{

  public string RestoreString(string s, int[] indices)
  {
    char[] result = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
      result[indices[i]] = s[i];
    }
    return new string(result);
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
