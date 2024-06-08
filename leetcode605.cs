/*
DIFFICULTY: Easy
QUESTION: 605. Can Place Flowers

DESCRIPTION:
You have a long flowerbed in which some of the plots are planted, and some are
not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty
and 1 means not empty, and an integer n, return true if n new flowers can be
planted in the flowerbed without violating the no-adjacent-flowers rule and
false otherwise.

INTUITION/APPROACH:
Question is harder than it seems because of the edge cases. I check the edge
cases first and plant to the start and end of the flowerbed if possible.
Then loop the rest (from 2nd first to 2nd last) and plant if possible.
*/

public class Solution
{
  public bool CanPlaceFlowers(int[] flowerbed, int n)
  {
    // edge case
    if (flowerbed.Length == 1)
    {
      return flowerbed[0] + n != 2;
    }
    // edge case at the start
    if (flowerbed[0] == 0 && flowerbed[1] == 0)
    {
      flowerbed[0] = 1;
      n--;
    }
    // edge case at the end
    if (flowerbed[^1] == 0 && flowerbed[^2] == 0)
    {
      flowerbed[^1] = 1;
      n--;
    }
    // loop rest
    for (int i = 1; i < flowerbed.Length - 1; i++)
    {
      if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
      {
        flowerbed[i] = 1;
        n--;
      }
      if (n <= 0) break;
    }
    return n <= 0;
  }

  public static void Main()
  {
    Solution app = new();
    app.CanPlaceFlowers([1, 0, 1, 0, 1, 0, 1], 1);
  }
}
