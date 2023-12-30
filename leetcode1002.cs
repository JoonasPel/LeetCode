using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1002. Find Common Characters

Given a string array words, return an array of all characters that show up in
all strings within the words (including duplicates). You may return the answer
in any order.

APPROACH:
Create an array where the char's ascii value - 97 is the index of that char.
Then use that as the count of char's occurence and loop the words and always
change the occurence count to the lowest one. For example if so far 'a' has
been seen 2 times, and now only once. change the count to 1. If some word has
zero 'a', change count to zero.
*/

public class Solution
{

  public IList<string> CommonChars(string[] words)
  {
    int[] totalCount = new int[26];
    foreach (char c in words[0])
    {
      totalCount[(int)c - 97]++;
    }
    int[] tempCount = new int[26];
    for (int i = 1; i < words.Length; i++)
    {
      foreach (char c in words[i])
        tempCount[(int)c - 97]++;
      for (int j = 0; j < 26; j++)
      {
        totalCount[j] = Math.Min(totalCount[j], tempCount[j]);
        tempCount[j] = 0;
      }

    }
    IList<string> result = new List<string>();
    for (int i = 0; i < 26; i++)
    {
      while (totalCount[i] > 0)
      {
        char xx = (char)(i + 97);
        result.Add(xx.ToString());
        totalCount[i]--;
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.CommonChars(new string[] { "bella", "label", "roller" });
  }
}
