using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1678. Goal Parser Interpretation

You own a Goal Parser that can interpret a string command. The command consists
of an alphabet of "G", "()" and/or "(al)" in some order. The Goal Parser will
interpret "G" as the string "G", "()" as the string "o", and "(al)" as the
string "al". The interpreted strings are then concatenated in the original
order.

Given the string command, return the Goal Parser's interpretation of command.

APPROACH:
Go through the string char by char and create a new Stringbuilder for the
result. We can jump some characters because if we find "(a", it continues "l)"
*/

public class Solution
{

  public string Interpret(string command)
  {
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < command.Length; i++)
    {
      if (command[i] == 'G')
      {
        result.Append('G');
      }
      else if (command[i + 1] == 'a')
      {
        result.Append("al");
        i += 3;
      }
      else
      {
        result.Append('o');
        i++;
      }
    }
    return result.ToString();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
