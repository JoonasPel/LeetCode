using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2108. Find First Palindromic String in the Array

Given an array of strings words, return the first palindromic string in the
array. If there is no such string, return an empty string "".

A string is palindromic if it reads the same forward and backward.

APPROACH:
Go through the words and run a palindrome check for them, return first found
palindrome. Palindrome check uses two index "pointers" left and right.
*/

public class Solution
{

  public string FirstPalindrome(string[] words)
  {
    foreach (string word in words)
    {
      if (isPalindromic(word))
        return word;
    }
    return "";

    static bool isPalindromic(string word)
    {
      int leftPtr = 0;
      int rightPtr = word.Length - 1;
      while (leftPtr < rightPtr)
      {
        if (word[leftPtr] != word[rightPtr])
          return false;
        leftPtr++;
        rightPtr--;
      }
      return true;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
