using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2351. First Letter to Appear Twice

Given a string s consisting of lowercase English letters, return the first
letter to appear twice.

Note:

    A letter a appears twice before another letter b if the second occurrence
    of a is before the second occurrence of b.
    s will contain at least one letter that appears twice.


APPROACH:
Just add chars to a set while going through the string and return the first
char that is already in the set.
*/


public class Solution
{
  public char RepeatedCharacter(string s)
  {
    HashSet<char> seen = new HashSet<char>();
    foreach (char c in s)
    {
      if (seen.Contains(c)) return c;
      seen.Add(c);
    }
    return ' ';
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
