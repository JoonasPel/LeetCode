using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 345. Reverse Vowels of a String

Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both
lower and upper cases, more than once.

APPROACH:
Create two "pointers" and start from left and right of the string, if both
left ptr and right ptr are vowels, swap and then move ptrs inner. if only left
ptr is vowel, move right ptr left until is is vowel too or it reaches left ptr.
Stringbuilder used for efficiency since it is mutable and the algo is O(n)
even thou it has nested loops it only goes through every char of string once.
*/

public class Program
{

  // remove static for leetcode
  public static string ReverseVowels(string s)
  {
    HashSet<char> vowels = new HashSet<char> {
      'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
    StringBuilder text = new StringBuilder(s);
    int leftIdx = 0;
    int rightIdx = s.Length - 1;
    while (leftIdx < rightIdx)
    {
      if (vowels.Contains(s[leftIdx]))
      {
        while (leftIdx < rightIdx)
        {
          if (vowels.Contains(s[rightIdx]))
          {
            (text[leftIdx], text[rightIdx]) = (text[rightIdx], text[leftIdx]);
            rightIdx--;
            break;
          }
          rightIdx--;
        }
      }
      leftIdx++;
    }
    return text.ToString();
  }

  public static void Main()
  {
    Console.WriteLine(ReverseVowels("leetcode"));
  }
}
