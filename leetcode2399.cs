/*
DIFFICULTY: Easy
QUESTION: 2399. Check Distances Between Same Letters

You are given a 0-indexed string s consisting of only lowercase English
letters, where each letter in s appears exactly twice. You are also given a
0-indexed integer array distance of length 26.

Each letter in the alphabet is numbered from 0 to 25
(i.e. 'a' -> 0, 'b' -> 1, 'c' -> 2, ... , 'z' -> 25).

In a well-spaced string, the number of letters between the two occurrences of
the ith letter is distance[i]. If the ith letter does not appear in s, then
distance[i] can be ignored.

Return true if s is a well-spaced string, otherwise return false.

INTUITION/APPROACH:
Save the first position of every char to a dictionary and when finding the
next occurence of the characters, check that the position is correct using
the distance array. Turn char to index by using the -97 ASCII offset.
*/

public class Solution
{
  public bool CheckDistances(string s, int[] distance)
  {
    Dictionary<int, int> positions = new();
    for (int i = 0; i < s.Length; i++)
    {
      if (positions.TryGetValue(s[i], out int pos))
      {
        if (i - pos - 1 != distance[s[i] - 97])
        {
          return false;
        }
      }
      else
      {
        positions.Add(s[i], i);
      }
    }
    return true;
  }

  public static void Main()
  {

    Solution app = new();
    Console.WriteLine(app.CheckDistances("abaccb",
    [1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]));
  }
}
