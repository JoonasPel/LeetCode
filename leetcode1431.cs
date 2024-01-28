/*
DIFFICULTY: Easy
QUESTION: 1431. Kids With the Greatest Number of Candies

There are n kids with candies. You are given an integer array candies, where
each candies[i] represents the number of candies the ith kid has, and an
integer extraCandies, denoting the number of extra candies that you have.

Return a boolean array result of length n, where result[i] is true if, after
giving the ith kid all the extraCandies, they will have the greatest number of
candies among all the kids, or false otherwise.

Note that multiple kids can have the greatest number of candies.

APPROACH:
Find the max candies any child has and calculate the min amount a child needs
to have to be the greatest if given all extra candies
*/

public class Solution
{
  public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
  {
    int minAmountToBeGreatest = candies.Max() - extraCandies;
    bool[] result = new bool[candies.Length];
    for (int i = 0; i < result.Length; i++)
    {
      result[i] = candies[i] >= minAmountToBeGreatest;
    }
    return result;
  }
}
