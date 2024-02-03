using System.Globalization;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2788. Split Strings by Separator

Given an array of strings words and a character separator, split each string in
words by separator.

Return an array of strings containing the new strings formed after the splits,
excluding empty strings.

Notes

    separator is used to determine where the split should occur, but it is not
    included as part of the resulting strings.
    A split may result in more than two strings.
    The resulting strings must maintain the same order as they were initially
    given.

APPROACH:
*/

public class Solution
{
  public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
  {
    IList<string> result = new List<string>();
    foreach (string word in words)
    {
      string[] items = word.Split(separator, StringSplitOptions.RemoveEmptyEntries);
      foreach (string item in items)
      {
        result.Add(item);
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
