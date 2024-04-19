/*
DIFFICULTY: Easy
QUESTION: 1844. Replace All Digits with Characters

DESCRIPTION:
You are given a 0-indexed string s that has lowercase English letters in its
even indices and digits in its odd indices.

There is a function shift(c, x), where c is a character and x is a digit, that
returns the xth character after c.

    For example, shift('a', 5) = 'f' and shift('x', 0) = 'x'.

For every odd index i, you want to replace the digit s[i] with shift(s[i-1], s[i]).

Return s after replacing all digits. It is guaranteed that shift(s[i-1], s[i]) will never exceed 'z'.

INTUITION/APPROACH:
*/

using System.Text;

public class Solution
{
  public char shift(char c, char i)
  {
    return (char)(c + char.GetNumericValue(i));
  }

  public string ReplaceDigits(string s)
  {
    StringBuilder result = new StringBuilder(s.Length);
    for (int i = 0; i < s.Length; i++)
    {
      if (i % 2 == 0) result.Append(s[i]);
      else result.Append(shift(s[i - 1], s[i]));
    }
    return result.ToString();
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.ReplaceDigits("a1c1e1"));
  }
}
