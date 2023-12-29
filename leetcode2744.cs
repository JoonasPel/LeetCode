using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2744. Find Maximum Number of String Pairs

You are given a 0-indexed array words consisting of distinct strings.

The string words[i] can be paired with the string words[j] if:

    The string words[i] is equal to the reversed string of words[j].
    0 <= i < j < words.length.

Return the maximum number of pairs that can be formed from the array words.

Note that each string can belong in at most one pair.

APPROACH:
Start from the end of nums array and save reversed Strings to a HashSet and
check for pairs while going towards the end of the array. I used custom
comparer here so instead of string, the words are saved as char[]. Was thinking
if it saves time not turning char arrays back to string but just save them as
char array, idk.
*/

public class Solution
{

  public class CustomComparer : IEqualityComparer<char[]>
  {
    public bool Equals(char[] x, char[] y)
    {
      return ArraysEqual(x, y);
    }

    public int GetHashCode(char[] obj)
    {
      unchecked
      {
        int hash = 17;
        foreach (char c in obj)
        {
          hash = hash * 31 + c.GetHashCode();
        }
        return hash;
      }
    }

    private bool ArraysEqual(char[] arr1, char[] arr2)
    {
      if (arr1.Length != arr2.Length)
        return false;
      for (int i = 0; i < arr1.Length; i++)
      {
        if (arr1[i] != arr2[i])
          return false;
      }
      return true;
    }
  }

  public int MaximumNumberOfStringPairs(string[] words)
  {
    int pairs = 0;
    var reversedWords = new HashSet<char[]>(new CustomComparer());
    for (int i = words.Length - 1; i >= 0; i--)
    {
      char[] charArr = words[i].ToCharArray();
      if (reversedWords.Contains(charArr)) pairs++;
      Array.Reverse(charArr);
      reversedWords.Add(charArr);
    }
    return pairs;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.MaximumNumberOfStringPairs(
      new string[] { "cd", "ac", "dc", "ca", "zz" }));
  }
}
