/*
DIFFICULTY: Easy
QUESTION: 1967. Number of Strings That Appear as Substrings in Word

Given an array of strings patterns and a string word, return the number of
strings in patterns that exist as a substring in word.

A substring is a contiguous sequence of characters within a string.

INTUITION/APPROACH:
*/


public class Solution
{
  public int NumOfStrings(string[] patterns, string word)
  {
    int result = 0;
    foreach (string pattern in patterns)
    {
      if (word.Contains(pattern)) result++;
    }
    return result;
  }

  public static void Main()
  {
  }
}
