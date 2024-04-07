/*
DIFFICULTY: Easy
QUESTION: 1281. Subtract the Product and Sum of Digits of an Integer

DESCRIPTION:
Given an integer number n, return the difference between the product of its
digits and the sum of its digits.

INTUITION/APPROACH:
*/


public class Solution
{
  public int SubtractProductAndSum(int n)
  {
    int product = 1;
    int sum = 0;
    while (n != 0)
    {
      int remainder = n % 10;
      product *= remainder;
      sum += remainder;
      n /= 10;
    }
    return product - sum;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.SubtractProductAndSum(234));
  }
}
