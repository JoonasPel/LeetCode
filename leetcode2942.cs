/*
DIFFICULTY: Easy
QUESTION: 2942. Find Words Containing Character

You are given a 0-indexed array of strings words and a character x.

Return an array of indices representing the words that contain the character x.

Note that the returned array may be in any order.

INTUITION/APPROACH:
*/

public class Solution
{
  public IList<int> FindWordsContaining(string[] words, char x)
  {
    IList<int> result = new List<int>();
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Contains(x))
      {
        result.Add(i);
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
