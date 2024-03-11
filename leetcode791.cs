/*
DIFFICULTY: Medium
QUESTION: 791. Custom Sort String

You are given two strings order and s. All the characters of order are unique
and were sorted in some custom order previously.

Permute the characters of s so that they match the order that order was sorted.
More specifically, if a character x occurs before a character y in order, then
x should occur before y in the permuted string.

Return any permutation of s that satisfies this property.

INTUITION/APPROACH:
A bit complicated solution probably. First save char positions in order to a
dictionary and then go through the string s and but all chars to correct
positions in an array of lists. After that turn the array of lists to a
continous string.
*/


public class Solution
{
  public string CustomSortString(string order, string s)
  {
    Dictionary<char, int> orders = new();
    for (int i = 0; i < order.Length; i++)
    {
      orders[order[i]] = i;
    }
    IList<char>[] perms = new IList<char>[27];
    perms[26] = new List<char>();
    foreach (char c in s)
    {
      if (orders.TryGetValue(c, out int pos))
      {
        if (perms[pos] == null)
        {
          perms[pos] = new List<char>();
        }
        perms[pos].Add(c);
      }
      else
      {
        perms[^1].Add(c);
      }
    }
    StringBuilder result = new();
    foreach (var perm in perms)
    {
      if (perm != null)
        result.Append(string.Join("", perm));
    }
    return result.ToString();
  }
}
