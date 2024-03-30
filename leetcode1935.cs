/*
DIFFICULTY: Easy
QUESTION: 1935. Maximum Number of Words You Can Type

DESCRIPTION:
There is a malfunctioning keyboard where some letter keys do not work.
All other keys on the keyboard work properly.

Given a string text of words separated by a single space (no leading
or trailing spaces) and a string brokenLetters of all distinct letter
keys that are broken, return the number of words in text you can fully
type using this keyboard.

INTUITION/APPROACH:
Save broken letters to Set. Go through the text and find words and
check chars if they are in the broken letters. This approach doesn't
need to create any new data structures from the text.
*/


public class Solution
{
  public int CanBeTypedWords(string text, string brokenLetters)
  {
    HashSet<char> broken = new HashSet<char>(brokenLetters);
    int result = 0;
    int wordStart = 0;
    for (int i = 0; i < text.Length; i++)
    {
      if (i + 1 == text.Length || text[i + 1] == ' ')
      {
        bool invalid = false;
        foreach (char c in text[wordStart..(i + 1)])
        {
          if (broken.Contains(c))
          {
            invalid = true;
            break;
          }
        }
        if (!invalid) result++;
        wordStart = i + 2;
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new();
    app.CanBeTypedWords("leet code", "lt");
  }
}
