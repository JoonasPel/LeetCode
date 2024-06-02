/*
DIFFICULTY: Medium
QUESTION: 2442. Count Number of Distinct Integers After Reverse Operations

DESCRIPTION:
You are given an array nums consisting of positive integers.

You have to take each integer in the array, reverse its digits, and add it to
the end of the array. You should apply this operation to the original integers
in nums.

Return the number of distinct integers in the final array.

INTUITION/APPROACH:
Add both original and reversed numbers into a Set to get distinct count.
Integers are reversed using only ints, very fast. No need for String/List tricks
*/

public class Solution
{
  public int CountDistinctIntegers(int[] nums)
  {
    HashSet<int> distincs = new();
    foreach (int num in nums)
    {
      distincs.Add(num);
      distincs.Add(ReverseInteger(num));
    }
    return distincs.Count;

    int ReverseInteger(int num)
    {
      int newNum = 0;
      while (num > 0)
      {
        newNum *= 10;
        newNum += num % 10;
        num /= 10;
      }
      return newNum;
    }
  }

  public static void Main()
  {
    Solution app = new();
    app.CountDistinctIntegers([1, 13, 10, 12, 31]);
  }
}
