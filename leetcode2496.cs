/*
DIFFICULTY: Easy
QUESTION: 2496. Maximum Value of a String in an Array

The value of an alphanumeric string can be defined as:

    The numeric representation of the string in base 10, if it comprises of
    digits only.
    The length of the string, otherwise.

Given an array strs of alphanumeric strings, return the maximum value of any
string in strs.

APPROACH:
*/

public class Solution
{
  public int MaximumValue(string[] strs)
  {
    int max = int.MinValue;
    foreach (string str in strs)
    {
      if (int.TryParse(str, out int number))
      {
        max = Math.Max(max, number);
      }
      else
      {
        max = Math.Max(max, str.Length);
      }
    }
    return max;
  }

  public static void Main()
  {
  }
}
