/*
DIFFICULTY: Easy
QUESTION: 2053. Kth Distinct String in an Array

A distinct string is a string that is present only once in an array.

Given an array of strings arr, and an integer k, return the kth distinct string
present in arr.
If there are fewer than k distinct strings, return an empty string "".

Note that the strings are considered in the order in which they appear in the
array.

INTUITION/APPROACH:
Save the frequencies of every string to a dictionary. Then enumerate through
the dictionary and return the kth string with frequency 1 (if exists).
!!! .NET Dictionary enumerates the items in their insertion order !!!
*/


public class Solution
{
  public string KthDistinct(string[] arr, int k)
  {
    Dictionary<string, int> frequencies = new();
    foreach (string s in arr)
    {
      frequencies.TryGetValue(s, out int count);
      frequencies[s] = count + 1;
    }
    int counter = 1;
    foreach (var item in frequencies)
    {
      if (item.Value == 1 && counter++ == k)
      {
        return item.Key;
      }
    }
    return "";
  }

  public static void Main()
  {
  }
}
