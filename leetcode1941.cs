using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1941. Check if All Characters Have Equal Number of Occurrences

Given a string s, return true if s is a good string, or false otherwise.

A string s is good if all the characters that appear in s have the same number
of occurrences (i.e., the same frequency).

APPROACH:
Go through the string and count char occurences into a dictionary. Then go
through the dictionary values and check that they are all equal.
*/


public class Solution
{

  public bool AreOccurrencesEqual(string s)
  {
    if (s == "") return true;
    Dictionary<char, int> occurences = new Dictionary<char, int>();
    foreach (char c in s)
    {
      occurences.TryGetValue(c, out int occurence);
      occurences[c] = occurence + 1;
    }
    int count = occurences.First().Value;
    foreach (var item in occurences)
    {
      if (count != item.Value) return false;
    }
    return true;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.AreOccurrencesEqual(""));
  }
}
