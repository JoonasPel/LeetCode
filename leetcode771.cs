using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 771. Jewels and Stones

You're given strings jewels representing the types of stones that are jewels,
and stones representing the stones you have. Each character in stones is a type
of stone you have. You want to know how many of the stones you have are also
jewels.

Letters are case sensitive, so "a" is considered a different type of stone
from "A".

APPROACH:
*/


public class Solution
{

  public int NumJewelsInStones(string jewels, string stones)
  {
    HashSet<char> validJewels = new HashSet<char>();
    foreach (char jewel in jewels)
    {
      validJewels.Add(jewel);
    }
    int jewelsFound = 0;
    foreach (char stone in stones)
    {
      if (validJewels.Contains(stone))
      {
        jewelsFound++;
      }
    }
    return jewelsFound;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.NumJewelsInStones("aA", "aAbbbbbXxA");
  }
}
