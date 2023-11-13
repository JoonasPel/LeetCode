using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 557. Reverse Words in a String III

Given a string s, reverse the order of characters in each word within
a sentence while still preserving whitespace and initial word order.

APPROACH:
Loop the string from the end and save chars to stringbuilder until a whitespace
is found. then add that word to a list, clear stringbuilder and
continue. reverse the list at the end and Join to a string.
*/

public class Program
{

  public static string ReverseWords(string s)
  {
    int sLength = s.Length;
    IList<string> reversedWords = new List<string>();
    char tempChar;
    StringBuilder tempWord = new StringBuilder();
    for (int i = sLength - 1; i >= 0; i--)
    {
      tempChar = s[i];
      if (tempChar != ' ')
      {
        tempWord.Append(tempChar);
      }
      else
      {
        reversedWords.Add(tempWord.ToString());
        tempWord.Clear();
      }
    }
    reversedWords.Add(tempWord.ToString());
    return string.Join(' ', reversedWords.Reverse());
  }

  public static void Main()
  {
    Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
  }
}
