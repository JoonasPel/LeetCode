/*
DIFFICULTY: Easy
QUESTION: 2160. Minimum Sum of Four Digit Number After Splitting Digits

You are given a positive integer num consisting of exactly four digits. Split
num into two new integers new1 and new2 by using the digits found in num.
Leading zeros are allowed in new1 and new2, and all the digits found in num
must be used.

    For example, given num = 2932, you have the following digits: two 2's,
    one 9 and one 3. Some of the possible pairs [new1, new2] are [22, 93],
    [23, 92], [223, 9] and [2, 329].

Return the minimum possible sum of new1 and new2.

INTUITION/APPROACH:
*/

public class Solution
{
  public int MinimumSum(int num)
  {
    char[] nums = num.ToString().ToCharArray();
    Array.Sort(nums);
    string xx = nums[0].ToString() + nums[3].ToString();
    string yy = nums[1].ToString() + nums[2].ToString();
    return int.Parse(xx) + int.Parse(yy);
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.MinimumSum(2932));
    Console.WriteLine(app.MinimumSum(4009));
  }
}
