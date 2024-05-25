/*
DIFFICULTY: Easy
QUESTION: 3110. Score of a String

DESCRIPTION:
You are given a string s. The score of a string is defined as the sum of the
absolute difference between the ASCII values of adjacent characters.

Return the score of s.

INTUITION/APPROACH:
*/

public class Solution
{

  public int ScoreOfString(string s)
  {
    int score = 0;
    for (int i = 1; i < s.Length; i++)
    {
      score += Math.Abs(s[i] - s[i - 1]);
    }
    return score;
  }

  public static void Main()
  {
  }
}
