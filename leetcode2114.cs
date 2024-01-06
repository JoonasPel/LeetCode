using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2114. Maximum Number of Words Found in Sentences

A sentence is a list of words that are separated by a single space with no
leading or trailing spaces.

You are given an array of strings sentences, where each sentences[i] represents
a single sentence.

Return the maximum number of words that appear in a single sentence.

APPROACH:
The word count of a sentence is spaces (' ') + 1. So we can just calculate the
amount of spaces in every sentence and find the max words. Also a little trick
to save time is to check, if the sentence .Length is smaller than current max
words found times 2. And if yes, skip that sentence. i.e. If we have already
found a sentence with 50 words, then there is no point in checking if a
sentence with under 100 characters has over 50 words. In practice this check
could be even higher but might introduce a risk of a mistake.
*/

public class Solution
{

  public int MostWordsFound(string[] sentences)
  {
    int result = 0;
    foreach (string sentence in sentences)
    {
      if (sentence.Length < result * 2) continue;
      result = Math.Max(result, sentence.Count(c => c == ' '));
    }
    return result + 1;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
