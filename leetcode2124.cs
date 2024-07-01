/*
DIFFICULTY: Easy
QUESTION: 2124. Check if All A's Appears Before All B's

DESCRIPTION:
Given a string s consisting of only the characters 'a' and 'b', return true if
every 'a' appears before every 'b' in the string. Otherwise, return false.

INTUITION/APPROACH:
Start from index 0 and keep track if we have seen 'b'. If we find 'a' and have
seen 'b', return false.

TIME COMPLEXITY: O(n)

THOUGHTS:
*/

public class Solution
{
  public bool CheckString(string s)
  {
    bool seenB = false;
    foreach (char c in s)
    {
      if (c == 'a' && seenB) return false;
      else if (c == 'b') seenB = true;
    }
    return true;
  }

  public static void Main()
  {
  }
}
