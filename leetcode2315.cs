/*
DIFFICULTY: Easy
QUESTION: 2315. Count Asterisks

DESCRIPTION:
You are given a string s, where every two consecutive vertical bars '|' are
grouped into a pair. In other words, the 1st and 2nd '|' make a pair, the 3rd
and 4th '|' make a pair, and so forth.

Return the number of '*' in s, excluding the '*' between each pair of '|'.

Note that each '|' will belong to exactly one pair.

INTUITION/APPROACH:
*/

public class Solution
{
  public int CountAsterisks(string s)
  {
    int asterisks = 0;
    bool insidePair = false;
    foreach (char c in s)
    {
      if (c == '|')
      {
        insidePair = !insidePair;
      }
      else if (!insidePair && c == '*')
      {
        asterisks++;
      }
    }
    return asterisks;
  }

  public static void Main()
  {
    Solution app = new();
    app.CountAsterisks("yo|uar|e**|b|e***au|tifu|l");
  }
}
