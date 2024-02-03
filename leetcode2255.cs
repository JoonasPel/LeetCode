/*
DIFFICULTY: Easy
QUESTION: 2255. Count Prefixes of a Given String

You are given a string array words and a string s, where words[i] and s
comprise only of lowercase English letters.

Return the number of strings in words that are a prefix of s.

A prefix of a string is a substring that occurs at the beginning of the string.
A substring is a contiguous sequence of characters within a string.
    given.

APPROACH:
*/

public class Solution
{
  public int CountPrefixes(string[] words, string s)
  {
    int result = 0;
    foreach (string word in words)
    {
      if (s.StartsWith(word)) result++;
    }
    return result;
  }

  public static void Main()
  {
  }
}
