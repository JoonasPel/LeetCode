using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1816. Truncate Sentence

A sentence is a list of words that are separated by a single space with no
leading or trailing spaces. Each of the words consists of only uppercase and
lowercase English letters (no punctuation).

    For example, "Hello World", "HELLO", and "hello world hello world" are all
    sentences.

You are given a sentence s​​​​​​ and an integer k​​​​​​. You want to truncate s​​​​​​ such that
it contains only the first k​​​​​​ words. Return s​​​​​​ after truncating it.

APPROACH:
Go through the sentence and count how many words are found. When found k words,
return the substring consisting of k words. Trim the end too.
*/


public class Solution
{

  public string TruncateSentence(string s, int k)
  {
    int wordsFound = 0;
    int index = 0;
    foreach (char c in s)
    {
      index++;
      if (c == ' ')
      {
        wordsFound++;
        if (wordsFound == k) break;
      }
    }
    return s.Substring(0, index).TrimEnd();
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.TruncateSentence("Hello how are you Contestant", 3));
    Console.WriteLine(app.TruncateSentence("Hello how are you Contestant", 4));
    Console.WriteLine(app.TruncateSentence("Hello how are you Contestant", 5));
  }
}
