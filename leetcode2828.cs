using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2828. Check if a String Is an Acronym of Words

Given an array of strings words and a string s, determine if s is an
acronym of words.

The string s is considered an acronym of words if it can be formed by
concatenating the first character of each string in words in order.
For example, "ab" can be formed from ["apple", "banana"], but it can't be
formed from ["bear", "aardvark"].

Return true if s is an acronym of words, and false otherwise. 

APPROACH:
Check that words list and string s are same length. Then just check that
the first char of every word is the same as the char in same index of the string
*/


public class Solution
{

  public bool IsAcronym(IList<string> words, string s)
  {
    if (s.Length != words.Count) return false;
    for (int i = 0; i < words.Count; i++)
    {
      if (words[i].First() != s[i]) return false;
    }
    return true;
  }

  public static void Main()
  {
  }
}
