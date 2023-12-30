using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1662. Check If Two String Arrays are Equivalent

Given two string arrays word1 and word2, return true if the two arrays
represent the same string, and false otherwise.

A string is represented by an array if the array elements concatenated in order
forms the string.

APPROACH:
Using "pointers" to check if all chars are the same. For both word1 and word2
we have two index numbers as "pointers", to point for the word in word1/2 and
for the specific char inside the word1/2. We move the "pointers" forward by 
increasing the char pointer by one if chars left and the word pointer by one
if no chars left.
The loop throws an IndexOutOfRange exception eventually and after that we also
check that both "pointers" are at the end. So there is no more words/chars left
which is the case if word1 and word2 dont have the same total char count.
*/

public class Solution
{

  public bool ArrayStringsAreEqual(string[] word1, string[] word2)
  {
    int word1ArrIdx = 0
    , word1CharIdx = 0
    , word2ArrIdx = 0
    , word2CharIdx = 0;
    try
    {
      while (true)
      {
        if (word1CharIdx == word1[word1ArrIdx].Length)
        {
          word1ArrIdx++;
          word1CharIdx = 0;
        }
        if (word2CharIdx == word2[word2ArrIdx].Length)
        {
          word2ArrIdx++;
          word2CharIdx = 0;
        }

        if (word1[word1ArrIdx][word1CharIdx] != word2[word2ArrIdx][word2CharIdx])
        {
          return false;
        }
        word1CharIdx++;
        word2CharIdx++;
      }
    }
    catch
    {
      if (word1.Length == word1ArrIdx && word2.Length == word2ArrIdx)
        return true;
      return false;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
