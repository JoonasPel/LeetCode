/*
DIFFICULTY: Medium
QUESTION: 1561. Maximum Number of Coins You Can Get

There are 3n piles of coins of varying size, you and your friends will take
piles of coins as follows:

    In each step, you will choose any 3 piles of coins (not necessarily
    consecutive).
    Of your choice, Alice will pick the pile with the maximum number of coins.
    You will pick the next pile with the maximum number of coins.
    Your friend Bob will pick the last pile.
    Repeat until there are no more piles of coins.

Given an array of integers piles where piles[i] is the number of coins in the
ith pile.

Return the maximum number of coins that you can have.

INTUITION/APPROACH:
Sort array descending and then take every second value until we have taken
piles.Length / 3 values. With this we basically always give the highest
available to Alice, take 2nd highest ourselves and give Bob the smallest ones.
*/

public class Solution
{

  public int MaxCoins(int[] piles)
  {
    int myPiles = piles.Length / 3 * 2;
    int myCoinsSum = 0;
    Array.Sort(piles, (a, b) => b - a);
    for (int i = 1; i <= myPiles; i += 2)
    {
      myCoinsSum += piles[i];
    }
    return myCoinsSum;
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.MaxCoins(new int[] { 2, 4, 1, 2, 7, 8 }));
    Console.WriteLine(app.MaxCoins(new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 }));
  }
}
