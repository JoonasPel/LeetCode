/*
DIFFICULTY: Easy
QUESTION: 2278. Percentage of Letter in String

DESCRIPTION:
Given a string s and a character letter, return the percentage of characters
in s that equal letter rounded down to the nearest whole percent.

INTUITION/APPROACH:
Divide letter occurence count by string length
*/

public class Solution
{
  public int PercentageLetter(string s, char letter)
  {
    return (int)Math.Floor((double)s.Count(c => c == letter) / s.Length * 100);
  }

  public static void Main()
  {
  }
}
