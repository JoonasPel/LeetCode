/*
DIFFICULTY: Medium
QUESTION: 1980. Find Unique Binary String

Given an array of strings nums containing n unique binary strings each of
length n, return a binary string of length n that does not appear in nums.
If there are multiple answers, you may return any of them.

INTUITION/APPROACH:
Turn binary numbers to integers and sort them. Then find an integer that is
missing because consecutive integers should increment by one. Also check if
the first number is zero or is it missing. And at the end if nothing is found,
we are missing the largest binary (only ones).
*/


public class Solution
{
  public string FindDifferentBinaryString(string[] nums)
  {
    int n = nums.Length;
    int[] numbers = new int[n];
    for (int i = 0; i < n; i++)
    {
      numbers[i] = Convert.ToInt32(nums[i], 2);
    }
    Array.Sort(numbers);
    if (numbers[0] != 0)
    {
      return new string('0', n);
    }
    for (int i = 1; i < n; i++)
    {
      if (numbers[i] - numbers[i - 1] != 1)
      {
        return (Convert.ToString(numbers[i] - 1, 2)).PadLeft(n, '0');
      }
    }
    return new string('1', n);
  }

  public static void Main()
  {
    Solution app = new();
    string res = app.FindDifferentBinaryString(
      new string[] { "000", "011", "001" });
    Console.WriteLine(res);
  }
}
