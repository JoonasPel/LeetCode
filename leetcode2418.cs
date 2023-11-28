using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2418. Sort the People

You are given an array of strings names, and an array heights that consists of
distinct positive integers. Both arrays are of length n.

For each index i, names[i] and heights[i] denote the name and height of the
ith person.

Return names sorted in descending order by the people's heights.

APPROACH:
Add people to a sorted list with their height as a key used in sorting. Then
get the names from the sorted list and return as an array.
*/


public class Solution
{

  class DescendingComparer : IComparer<int>
  {
    public int Compare(int x, int y)
    {
      return y.CompareTo(x);
    }
  }

  public string[] SortPeople(string[] names, int[] heights)
  {
    var people = new SortedList<int, string>(new DescendingComparer());
    for (int i = 0; i < names.Length; i++)
    {
      people.Add(heights[i], names[i]);
    }
    var sortedPeople = people.ToArray();
    string[] result = new string[names.Length];
    int index = 0;
    foreach (KeyValuePair<int, string> person in sortedPeople)
    {
      result[index] = person.Value;
      index++;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
