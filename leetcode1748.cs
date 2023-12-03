using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1748. Sum of Unique Elements

You are given an integer array nums. The unique elements of an array are the
elements that appear exactly once in the array.

Return the sum of all the unique elements of nums.

APPROACH:
Go through the nums array and save numbers occurance count into a dictionary.
While doing this, add the number to the sum already and if the same number is
found second time, remove it from the sum. If found even more times, do nothing

One could also just loop the dictionary items again and add numbers that have
occurance count 1 to the sum. But I think this is slower because all numbers
are hashed twice, once when added to the dictionary, and second time when
searched again.
*/


public class Solution
{
  public int SumOfUnique(int[] nums)
  {
    Dictionary<int, int> numOccurances = new Dictionary<int, int>();
    int sum = 0;
    foreach (int num in nums)
    {
      if (!numOccurances.TryGetValue(num, out int occuranceCount))
      {
        numOccurances[num] = 1;
        sum += num;
      }
      else
      {
        if (occuranceCount == 1) sum -= num; // same number found the 2nd time
        numOccurances[num]++;
      }
    }
    return sum;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.SumOfUnique(new int[] { 1, 2, 3, 2 }));
  }
}
