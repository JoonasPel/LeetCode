/*
DIFFICULTY: Easy
QUESTION: 2716. Minimize String Length

Given a 0-indexed string s, repeatedly perform the following operation any
number of times:

    Choose an index i in the string, and let c be the character in position i.
    Delete the closest occurrence of c to the left of i (if any) and the
    closest occurrence of c to the right of i (if any).

Your task is to minimize the length of s by performing the above operation any
number of times.

Return an integer denoting the length of the minimized string.

INTUITION/APPROACH:
After performing maximum deletions we will just have one of every character
left. So answer is the amount of unique chars in the string.
*/

public class Solution
{
  public int MinimizedStringLength(string s)
  {
    return new HashSet<char>(s).Count;
  }

  public static void Main()
  {
  }
}
