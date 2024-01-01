using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2981. Find Longest Special Substring That Occurs Thrice I
Q2 of Weekly Contest 378. I did this during the contest.

You are given a string s that consists of lowercase English letters.

A string is called special if it is made up of only a single character.
For example, the string "abc" is not special, whereas the strings "ddd", "zz",
and "f" are special.

Return the length of the longest special substring of s which occurs at least
thrice, or -1 if no special substring occurs at least thrice.

A substring is a contiguous non-empty sequence of characters within a string.

APPROACH:
Bruteforce approach where we find all possible substrings with a sliding window
that has all possible sizes. When finding substrings, if the substring consists
of only same charaters, save it to the dictionary as key and value is the count
of its total occurence. At the end, search the longest substring from the
dictionary that has count of 3 or more.
*/

public class Solution
{

  public int MaximumLength(string s)
  {
    Dictionary<string, int> occurence = new Dictionary<string, int>();
    int windowSize = 1;
    while (windowSize < s.Length)
    {
      int startIndex = 0;
      while (startIndex + windowSize <= s.Length)
      {
        string substring = s.Substring(startIndex, windowSize);
        if (substring.Distinct().Count() == 1)
        {
          occurence.TryGetValue(substring, out int count);
          occurence[substring] = count + 1;
        }
        startIndex++;
      }
      windowSize++;
    }

    int longest = -1;
    foreach (var item in occurence)
    {
      if (item.Value >= 3)
      {
        longest = Math.Max(longest, item.Key.Length);
      }
    }
    return longest;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MaximumLength("aaaa"));
    Console.WriteLine(app.MaximumLength("abcdef"));
    Console.WriteLine(app.MaximumLength("abcaba"));
    Console.WriteLine(app.MaximumLength("cccerrrecdcdccedecdcccddeeeddcdcddedccdceeedccecde"));
    Console.WriteLine(app.MaximumLength("ttttt"));
  }
}
