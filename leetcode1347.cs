using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1347. Minimum Number of Steps to Make Two Strings Anagram

You are given two strings of the same length s and t. In one step you can
choose any character of t and replace it with another character.

Return the minimum number of steps to make t an anagram of s.

An Anagram of a string is a string that contains the same characters with a
different (or the same) ordering.

APPROACH:
Calculate the char counts in both strings are check how many different chars
(including count) are in string t in comparison to s. The difference is the
answer.
*/


public class Solution
{

  public int MinSteps(string s, string t)
  {
    Dictionary<char, int> occurences = new Dictionary<char, int>();
    foreach (char c in s)
    {
      occurences.TryGetValue(c, out int value);
      occurences[c] = value + 1;
    }
    int similarChars = 0;
    int tempVal;
    foreach (char c in t)
    {
      if (occurences.TryGetValue(c, out int value))
      {
        tempVal = value - 1;
        if (tempVal >= 0)
        {
          occurences[c] = tempVal;
          similarChars++;
        }
      }
    }
    return t.Length - similarChars;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MinSteps("leetcode", "practice"));
    Console.WriteLine(app.MinSteps("anagram", "mangaar"));
    Console.WriteLine(app.MinSteps("bab", "aba"));
  }
}
