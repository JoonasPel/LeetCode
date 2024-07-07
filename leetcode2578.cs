/*
DIFFICULTY: Easy
QUESTION: 2578. Split With Minimum Sum

DESCRIPTION:
Given a positive integer num, split it into two non-negative integers num1 and
num2 such that:

    The concatenation of num1 and num2 is a permutation of num.
        In other words, the sum of the number of occurrences of each digit in
        num1 and num2 is equal to the number of occurrences of that digit in
        num.
    num1 and num2 can contain leading zeros.

Return the minimum possible sum of num1 and num2.

Notes:

    It is guaranteed that num does not contain any leading zeros.
    The order of occurrence of the digits in num1 and num2 may differ from the
    order of occurrence of num.

INTUITION/APPROACH:
Sort digits in ascending order and then create num1 and num2 by adding
a digit to them alternatively to make both nums as small as possible.
e.g. 10063 => 0 0 1 3 6 => num1 = 003 and num2 = 016

TIME COMPLEXITY: O(n)

THOUGHTS:
*/

using System.Text;

public class Solution
{
  public int SplitNum(int num)
  {
    char[] digits = num.ToString().ToCharArray();
    Array.Sort(digits);
    StringBuilder num1 = new();
    StringBuilder num2 = new();
    for (int i = 0; i < digits.Length; i++)
    {
      if (i % 2 == 0) num1.Append(digits[i]);
      else num2.Append(digits[i]);
    }
    return int.Parse(num1.ToString()) + int.Parse(num2.ToString());
  }

  public static void Main()
  {
  }
}
