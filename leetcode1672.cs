using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1672. Richest Customer Wealth

You are given an m x n integer grid accounts where accounts[i][j] is
the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the
wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank
accounts. The richest customer is the customer that has the maximum
wealth.

APPROACH:
Sum values in every row and find maximum.
*/


public class Solution
{
  public int MaximumWealth(int[][] accounts)
  {
    int maxWealth = 0;
    foreach (int[] account in accounts)
    {
      maxWealth = Math.Max(maxWealth, account.Sum());
    }
    return maxWealth;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
