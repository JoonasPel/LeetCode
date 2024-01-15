using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 3006. Find Beautiful Indices in the Given Array I
Q2 of Weekly Contest 380. I did this during the contest.

You are given a 0-indexed string s, a string a, a string b, and an integer k.

An index i is beautiful if:

    0 <= i <= s.length - a.length
    s[i..(i + a.length - 1)] == a
    There exists an index j such that:
        0 <= j <= s.length - b.length
        s[j..(j + b.length - 1)] == b
        |j - i| <= k

Return the array that contains beautiful indices in sorted order from smallest
to largest.

APPROACH:
Loop s and if we find a, then loop the s again to find b. But only from the
range that is needed to be checked which is from i-k to i+k+1. This range thing
is because the requirement |j - i| <= k. Meaning basically that the b has to be
found near enough.
*/

public class Solution
{
  public IList<int> BeautifulIndices(string s, string a, string b, int k)
  {
    IList<int> result = new List<int>();
    for (int i = 0; i < (s.Length - a.Length + 1); i++)
    {
      if (s[i..(i + a.Length)] == a)
      {
        int startIdx = Math.Max(0, i - k);
        int endIdx = Math.Min(s.Length - b.Length + 1, i + k + 1);
        for (int j = startIdx; j < endIdx; j++)
        {
          if (s[j..(j + b.Length)] == b && Math.Abs(j - i) <= k)
          {
            result.Add(i);
            break;
          }
        }
      }
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();

    var res = app.BeautifulIndices("wfvxfzut", "wfv", "ut", 6);

    foreach (var item in res)
    {
      Console.WriteLine(item);
    }
  }

}