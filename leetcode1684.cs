using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1684. Count the Number of Consistent Strings

You are given a string allowed consisting of distinct characters and an array
of strings words. A string is consistent if all characters in the string appear
in the string allowed.

Return the number of consistent strings in the array words.

APPROACH:
*/


public class Solution
{

  public int CountConsistentStrings(string allowed, string[] words)
  {
    HashSet<char> allowedChars = new HashSet<char>();
    foreach (char c in allowed)
    {
      allowedChars.Add(c);
    }
    int consistentCount = 0;
    bool tempValid;
    foreach (string word in words)
    {
      tempValid = true;
      foreach (char c in word)
      {
        if (!allowedChars.Contains(c))
        {
          tempValid = false;
          break;
        }
      }
      if (tempValid) consistentCount++;
    }
    return consistentCount;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
