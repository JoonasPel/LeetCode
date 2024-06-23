/*
DIFFICULTY: Easy
QUESTION: 1704. Determine if String Halves Are Alike

DESCRIPTION:
You are given a string s of even length. Split this string into two halves of
equal lengths, and let a be the first half and b be the second half.

Two strings are alike if they have the same number of vowels
('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains
uppercase and lowercase letters.

Return true if a and b are alike. Otherwise, return false.

INTUITION/APPROACH:
Using Set to check if a char is vowel or not, loop the halfs and check if the
vowel count is the same.

TIME COMPLEXITY: O(n)

THOUGHTS:
One could also check the remaining characters while looping the second half b,
and see if it is even possible to reach enough vowels to match the first half a.
Depends on the average inputs if adding this is faster or not. This check could
also happen every 20th character or something like that.
*/

public class Solution
{
  public bool HalvesAreAlike(string s)
  {
    HashSet<char> vowels = new()
    {
      'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',
    };
    int aVowels = 0;
    int bVowels = 0;
    for (int i = 0; i < s.Length / 2; i++)
    {
      if (vowels.Contains(s[i])) aVowels++;
    }
    for (int i = s.Length / 2; i < s.Length; i++)
    {
      if (vowels.Contains(s[i])) bVowels++;
    }
    return aVowels == bVowels;
  }

  public static void Main()
  {
  }
}
