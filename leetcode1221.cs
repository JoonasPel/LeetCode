/*
DIFFICULTY: Easy
QUESTION: 1221. Split a String in Balanced Strings

DESCRIPTION:
Balanced strings are those that have an equal quantity of 'L' and 'R' characters.

Given a balanced string s, split it into some number of substrings such that:

    Each substring is balanced.

Return the maximum number of balanced strings you can obtain.

INTUITION/APPROACH:
Not the simpliest way, but I use recursion to give a balanced substring to
another recursion call that tries to divide it more and so on.. Key point is
that the actual substring is not given but instead two index "pointers" left
and right, to make it a lot faster. And also the total count of 'L's and 'R's
is given to the recursion call so it doesn't have to be calculated again.
*/


public class Solution
{
  public int BalancedStringSplit(string s)
  {
    int Lcount = 0;
    int Rcount = 0;
    foreach (char c in s)
    {
      if (c == 'L') Lcount++;
      else Rcount++;
    }
    return Visit(0, s.Length - 1, Lcount, Rcount);

    int Visit(int leftPtr, int rightPtr, int Lcount, int Rcount)
    {
      int tempLcount = 0;
      int tempRcount = 0;
      for (int i = leftPtr; i < rightPtr; i++)
      {
        if (s[i] == 'L') tempLcount++;
        else tempRcount++;
        if (tempLcount == tempRcount && (Lcount - tempLcount) == (Rcount - tempRcount))
        {
          int partsL = Visit(leftPtr, i, tempLcount, tempRcount);
          int partsR = Visit(i + 1, rightPtr, Lcount - tempLcount, Rcount - tempRcount);
          return partsL + partsR;
        }
      }
      return 1;
    }
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.BalancedStringSplit("RLRRLLRLRL"));
    Console.WriteLine(app.BalancedStringSplit("RLRRRLLRLL"));
    Console.WriteLine(app.BalancedStringSplit("LLLLRRRR"));
  }
}

