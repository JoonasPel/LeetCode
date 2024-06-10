/*
DIFFICULTY: Easy
QUESTION: 2535. Difference Between Element Sum and Digit Sum of an Array

DESCRIPTION:
You are given a positive integer array nums.

    The element sum is the sum of all the elements in nums.
    The digit sum is the sum of all the digits (not necessarily distinct) that
    appear in nums.

Return the absolute difference between the element sum and digit sum of nums.

Note that the absolute difference between two integers x and y is defined as
|x - y|.

INTUITION/APPROACH:
*/

public class Solution
{
  public int DifferenceOfSum(int[] nums)
  {
    int digitSum = 0;
    int elementSum = 0;
    foreach (int num in nums)
    {
      elementSum += num;
      digitSum += CalcDigitSum(num);
    }
    return Math.Abs(elementSum - digitSum);

    int CalcDigitSum(int number)
    {
      int res = 0;
      while (number > 0)
      {
        res += number % 10;
        number /= 10;
      }
      return res;
    }
  }

  public static void Main()
  {
    Solution app = new();
    app.DifferenceOfSum([1, 15, 6, 3]);
  }
}
