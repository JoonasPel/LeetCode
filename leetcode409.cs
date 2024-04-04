/*
DIFFICULTY: Easy
QUESTION: 409. Longest Palindrome

DESCRIPTION:
Given a string s which consists of lowercase or uppercase letters, return the
length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome
here.

INTUITION/APPROACH:
All even character freqs can be used "fully". Odd freqs can be used only for
the even part e.g. freq -1. And additionally one more char can be added to the
middle of the palindrome.
For example with character freqs like the below:
a => 5
b => 10
c => 1
We can use all b's and 4 a's and also one 'a' OR one 'c'. So 10 + 4 + 1 = 15
*/


public class Solution
{
  public int LongestPalindrome(string s)
  {
    Dictionary<char, int> freqs = new();
    foreach (char c in s)
    {
      freqs.TryGetValue(c, out int freq);
      freqs[c] = freq + 1;
    }
    bool oddExists = false;
    int result = 0;
    foreach (var item in freqs)
    {
      if (item.Value % 2 == 0) result += item.Value;
      else
      {
        oddExists = true;
        result += item.Value - 1;
      }
    }
    return oddExists ? result + 1 : result;
  }

  public static void Main()
  {
  }
}
