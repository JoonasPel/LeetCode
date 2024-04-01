/*
DIFFICULTY: Easy
QUESTION: 2706. Buy Two Chocolates

DESCRIPTION:
You are given an integer array prices representing the prices of
various chocolates in a store. You are also given a single integer
money, which represents your initial amount of money.

You must buy exactly two chocolates in such a way that you still have
some non-negative leftover money. You would like to minimize the sum
of the prices of the two chocolates you buy.

Return the amount of money you will have leftover after buying the two
chocolates. If there is no way for you to buy two chocolates without
ending up in debt, return money. Note that the leftover must be
non-negative.

INTUITION/APPROACH:
Get two smallest prices from prices array and check if we can afford
them.
Could also just sort the array (O(n*logn)) but this approach is O(n)
*/


public class Solution
{
  public int BuyChoco(int[] prices, int money)
  {
    int smallest = int.MaxValue;
    int secondSmallest = int.MaxValue;
    foreach (int price in prices)
    {
      if (price < smallest)
      {
        secondSmallest = smallest;
        smallest = price;
      }
      else if (price < secondSmallest)
      {
        secondSmallest = price;
      }
    }
    int leftOver = money - smallest - secondSmallest;
    return leftOver >= 0 ? leftOver : money;
  }

  public static void Main()
  {
  }
}
