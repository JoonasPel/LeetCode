/*
DIFFICULTY: Medium
QUESTION: 1689. Partitioning Into Minimum Number Of Deci-Binary Numbers

A decimal number is called deci-binary if each of its digits is either 0 or 1
without any leading zeros. For example, 101 and 1100 are deci-binary, while 112
and 3001 are not.

Given a string n that represents a positive decimal integer, return the minimum
number of positive deci-binary numbers needed so that they sum up to n.

INTUITION/APPROACH:
Minimum number is the number we need to create the largest digit in input
*/

public class Solution
{
  public int MinPartitions(string n)
  {
    /*
    oneliner but does not have early stop:
    return n.Max() - 48;
    */

    double maxDigit = -1;
    for (int i = 0; i < n.Length; i++)
    {
      if (n[i] == '9')
      {
        return 9;
      }
      else
      {
        maxDigit = Math.Max(maxDigit, char.GetNumericValue(n[i]));
      }
    }
    return (int)maxDigit;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.MinPartitions("799234"));
  }
}
