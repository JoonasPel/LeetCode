/*
DIFFICULTY: Easy
QUESTION: 1768. Merge Strings Alternately

You are given two strings word1 and word2. Merge the strings by adding letters
in alternating order, starting with word1. If a string is longer than the
other, append the additional letters onto the end of the merged string.

Return the merged string.

INTUITION/APPROACH:
Add chars alternately to a stringbuilder until one word runs out of chars.
Then add the remaining from the longer word (if exists).
*/


using System.Text;

public class Solution
{
  public string MergeAlternately(string word1, string word2)
  {
    StringBuilder result = new(word1.Length + word2.Length);
    int i;
    for (i = 0; i < Math.Min(word1.Length, word2.Length); i++)
    {
      result.Append(word1[i]);
      result.Append(word2[i]);
    }
    if (i < word1.Length)
    {
      result.Append(word1[i..]);
    }
    else if (i < word2.Length)
    {
      result.Append(word2[i..]);
    }
    return result.ToString();
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.MergeAlternately("cf", "eee"));
  }
}
