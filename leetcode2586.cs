/*
DIFFICULTY: Easy
QUESTION: 2586. Count the Number of Vowel Strings in Range

DESCRIPTION:
You are given a 0-indexed array of string words and two integers left and right.

A string is called a vowel string if it starts with a vowel character and ends
with a vowel character where vowel characters are 'a', 'e', 'i', 'o', and 'u'.

Return the number of vowel strings words[i] where i belongs to the inclusive
range [left, right].

INTUITION/APPROACH:
Loop included words and using a function check if it is valid vowel string.

TIME COMPLEXITY: O(n)

THOUGHTS:
HashSet for the vowels checking could also be used, but the hashing overhead
would probably make it slower than the "manual" approach used here.
*/

public class Solution
{
  public int VowelStrings(string[] words, int left, int right)
  {
    int vowelStrings = 0;
    for (int i = left; i <= right; i++)
    {
      if (isVowel(words[i][0]) && isVowel(words[i][^1]))
      {
        vowelStrings++;
      }
    }
    return vowelStrings;

    bool isVowel(char c)
    {
      return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
  }

  public static void Main()
  {
  }
}
