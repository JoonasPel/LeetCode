/*
DIFFICULTY: Easy
QUESTION: 2974. Minimum Number Game

You are given a 0-indexed integer array nums of even length and there is also
an empty array arr. Alice and Bob decided to play a game where in every round
Alice and Bob will do one move. The rules of the game are as follows:

    Every round, first Alice will remove the minimum element from nums, and
    then Bob does the same.
    Now, first Bob will append the removed element in the array arr, and then
    Alice does the same.
    The game continues until nums becomes empty.

Return the resulting array arr.

APPROACH:
Sort the array and add numbers to a result array with a "jumping" index ptr.
*/

public class Solution
{
  public int[] NumberGame(int[] nums)
  {
    Array.Sort(nums);
    int[] result = new int[nums.Length];
    int indexPtr = 1;
    foreach (int num in nums)
    {
      result[indexPtr] = num;
      if (indexPtr % 2 != 0) indexPtr--;
      else indexPtr += 3;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.NumberGame(new int[] { 5, 4, 2, 3 });
  }
}