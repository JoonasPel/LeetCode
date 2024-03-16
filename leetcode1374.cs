/*
DIFFICULTY: Easy
QUESTION: 1374. Generate a String With Characters That Have Odd Counts

Given an integer n, return a string with n characters such that each character
in such string occurs an odd number of times.

The returned string must contain only lowercase English letters. If there are
multiples valid strings, return any of them.  

INTUITION/APPROACH:
With even n we can put "a" and rest "b" chars. With odd "ab" and rest "c" chars
*/

public class Solution
{
  public string GenerateTheString(int n)
  {
    if (n == 1)
    {
      return "a";
    }
    else if (n % 2 == 0)
    {
      return "a" + new string('b', n - 1);
    }
    else
    {
      return "ab" + new string('c', n - 2);
    }
  }

  public static void Main()
  {
  }
}
