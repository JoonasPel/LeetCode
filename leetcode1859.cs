/*
DIFFICULTY: Easy
QUESTION: 1859. Sorting the Sentence

A sentence is a list of words that are separated by a single space with no
leading or trailing spaces. Each word consists of lowercase and uppercase
English letters.

A sentence can be shuffled by appending the 1-indexed word position to each
word then rearranging the words in the sentence.

    For example, the sentence "This is a sentence" can be shuffled as
    "sentence4 a3 is2 This1" or "is2 sentence4 This1 a3".

Given a shuffled sentence s containing no more than 9 words, reconstruct and
return the original sentence.

INTUITION/APPROACH:
Go through the string and save word start and end position indexes into array.
Then insert the string into stringbuilder using those positions.
*/

using System.Text;

public class Solution
{
  public string SortSentence(string s)
  {
    (int start, int end)[] wordsPos = new (int start, int end)[10];
    int start = 0;
    for (int i = 1; i < s.Length; i++)
    {
      if (s[i] > 48 && s[i] < 58)
      {
        wordsPos[s[i] - '0' - 1] = (start, i);
        start = i + 2;
      }
    }
    StringBuilder result = new();
    foreach ((int start, int end) wordPos in wordsPos)
    {
      if (wordPos != (0, 0))
      {
        result.Append(' ');
        result.Append(s[wordPos.start..wordPos.end]);
      }
    }
    return result.ToString().TrimStart();
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.SortSentence("is2 sentence4 This1 a3"));
  }
}
