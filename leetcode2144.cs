using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2144. Minimum Cost of Buying Candies With Discount

A shop is selling candies at a discount. For every two candies sold,
the shop gives a third candy for free.

The customer can choose any candy to take away for free as long as the
cost of the chosen candy is less than or equal to the minimum cost of the two candies bought.

    For example, if there are 4 candies with costs 1, 2, 3, and 4, and
    the customer buys candies with costs 2 and 3, they can take the
    candy with cost 1 for free, but not the candy with cost 4.

Given a 0-indexed integer array cost, where cost[i] denotes the cost
of the ith candy, return the minimum cost of buying all the candies.

APPROACH:
Sort the cost descending and then count total cost by summing up and 
every third candy is free.
*/


public class Solution
{

  public int MinimumCost(int[] cost)
  {
    Array.Sort(cost, (a, b) => b - a);
    int totalCost = 0;
    int index = 0;
    foreach (int candyCost in cost)
    {
      if (++index % 3 != 0)
      {
        totalCost += candyCost;
      }
    }
    return totalCost;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.MinimumCost(new int[] { 6, 5, 7, 9, 2, 2 });
  }
}
