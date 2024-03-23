/*
DIFFICULTY: Easy
QUESTION: 3019. Number of Changing Keys

You are given a 0-indexed string s typed by a user. Changing a key is defined
as using a key different from the last used key. For example, s = "ab" has a
change of a key while s = "bBBb" does not have any.

Return the number of times the user had to change the key.

Note: Modifiers like shift or caps lock won't be counted in changing the key
that is if a user typed the letter 'a' and then the letter 'A' then it will
not be considered as a changing of key.

INTUITION/APPROACH:
Loop the chars and every time the earlier char is different, increase result.
Turn chars to lower to make this not case sensitive.
*/


public class Solution
{
  public int CountKeyChanges(string s)
  {
    int result = 0;
    for (int i = 1; i < s.Length; i++)
    {
      if (char.ToLower(s[i - 1]) != char.ToLower(s[i]))
      {
        result++;
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.CountKeyChanges("aAbBcCDVD"));
  }
}
