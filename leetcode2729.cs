/*
DIFFICULTY: Easy
QUESTION: 2729. Check if The Number is Fascinating

DESCRIPTION:
You are given an integer n that consists of exactly 3 digits.

We call the number n fascinating if, after the following modification, the
resulting number contains all the digits from 1 to 9 exactly once and does not
contain any 0's:

    Concatenate n with the numbers 2 * n and 3 * n.

Return true if n is fascinating, or false otherwise.

Concatenating two numbers means joining them together. For example, the
concatenation of 121 and 371 is 121371.

INTUITION/APPROACH:
*/


public class Solution
{
  public bool IsFascinating(int n)
  {
    string number = n.ToString() + (2 * n).ToString() + (3 * n).ToString();
    if (number.Length != 9) return false;
    char[] sorted = number.ToCharArray();
    Array.Sort(sorted);
    return new string(sorted) == "123456789";
  }

  public static void Main()
  {
    Solution app = new();
    Console.WriteLine(app.IsFascinating(192));
  }
}

