using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2000. Reverse Prefix of Word

Given a 0-indexed string word and a character ch, reverse the segment of word
that starts at index 0 and ends at the index of the first occurrence
of ch (inclusive). If the character ch does not exist in word, do nothing.

    For example, if word = "abcdefd" and ch = "d", then you should reverse
    the segment that starts at 0 and ends at 3 (inclusive).
    The resulting string will be "dcbaefd".

Return the resulting string.

APPROACH:
Loop through word and push chars to a stack. When ch is found, add together
stack as a string and the remaining word after ch.
*/

public class Program
{

  // remove static for leetcode
  public static string ReversePrefix(string word, char ch)
  {
    if (!word.Contains(ch)) return word;

    Stack<char> stack = new Stack<char>();
    char tempWord;
    for (int i = 0; i < word.Length; i++)
    {
      tempWord = word[i];
      stack.Push(tempWord);
      if (tempWord == ch)
      {
        word = new string(stack.ToArray()) + word[(i + 1)..];
        break;
      }
    }
    return word;
  }

  public static void Main()
  {
    Console.WriteLine(ReversePrefix(word: "abcdefd", ch: 'd'));
  }
}
