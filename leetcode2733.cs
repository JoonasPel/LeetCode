/*
DIFFICULTY: Easy
QUESTION: 2733. Neither Minimum nor Maximum

Given an integer array nums containing distinct positive integers, find and
return any number from the array that is neither the minimum nor the maximum
value in the array, or -1 if there is no such number.

Return the selected integer.

INTUITION/APPROACH:
Loop the nums array and keep count of min and max number found. If a number
between min and max is found, return it immediately, meaning the whole array
might not get looped. If not found, then loop again with "verified" min and max
and find the answer.

For example an array [ 3, 2, 1, 4, 6, 5, 7, 8, 9 ... , 10000000 ] would only
get evaluated to the number 5 which is then returned because it is noticed that
there is bigger (6) and smaller (e.g. 3) found already.
I tested that an array of random values is only evaluated to index 3 on average
before finding a valid number for returning.
*/

public class Solution
{
  public int FindNonMinOrMax(int[] nums)
  {
    if (nums.Length <= 2) return -1;
    int min = int.MaxValue;
    int max = int.MinValue;
    int i = 1;
    foreach (int num in nums)
    {
      Console.WriteLine(i++);
      if (num < max && num > min) return num;
      max = Math.Max(max, num);
      min = Math.Min(min, num);
    }
    foreach (int num in nums)
    {
      if (num < max && num > min) return num;
    }
    return -1;
  }

  public static void Main()
  {
    Solution app = new();
    int[] arr = Enumerable.Range(0, 1000).ToArray();
    Random rand = new();
    rand.Shuffle(arr);
    int res = app.FindNonMinOrMax(arr);
    Console.WriteLine(res);
  }
}
