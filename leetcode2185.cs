using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2185. Counting Words With a Given Prefix

You are given an array of strings words and a string pref.

Return the number of strings in words that contain pref as a prefix.

A prefix of a string s is any leading contiguous substring of s.

APPROACH:
Go through the words and check that a word[i] == pref for every index in pref
*/

public class Solution
{

  public int PrefixCount(string[] words, string pref)
  {
    int result = 0;
    foreach (string word in words)
    {
      if (word.Length < pref.Length) continue;
      result++;
      for (int i = 0; i < pref.Length; i++)
      {
        if (word[i] != pref[i])
        {
          result--;
          break;
        }
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
