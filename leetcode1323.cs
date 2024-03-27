/*
DIFFICULTY: Easy
QUESTION: 1323. Maximum 69 Number

DESCRIPTION:
You are given a positive integer num consisting only of digits 6 and 9.

Return the maximum number you can get by changing at most one digit
(6 becomes 9, and 9 becomes 6).

INTUITION/APPROACH:
Change the "largest" 6 to 9 if exists
*/


public class Solution
{
  public int Maximum69Number(int num)
  {
    // Question constraint is: 1 <= num <= 10^4
    switch (num)
    {
      case 9:
        return num;
      case 99:
        return num;
      case 999:
        return num;
      case 9999:
        return num;
      default:
        break;
    }

    char[] digits = num.ToString().ToCharArray();
    for (int i = 0; i < digits.Length; i++)
    {
      if (digits[i] == '6')
      {
        digits[i] = '9';
        return int.Parse(digits);
      }
    }
    return num;
  }

  public static void Main()
  {
    Solution app = new();
  }
}

