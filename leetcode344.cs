using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 344. Reverse String

Write a function that reverses a string. The input string is given as
an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

APPROACH:
Use two-pointers, one starting from left and one from right. Swap the values
in the char arr and move ptrs one step inner as long as leftptr < rightptr.
*/

public class Solution
{

  public void ReverseString(char[] s)
  {
    int leftPtrIndex = 0;
    int rightPtrIndex = s.Length - 1;
    while (leftPtrIndex < rightPtrIndex)
    {
      (s[leftPtrIndex], s[rightPtrIndex]) = (s[rightPtrIndex--], s[leftPtrIndex++]);
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
    char[] text = new char[] { 'l', 'e', 'e', 't', 'c', 'o', 'd', 'e' };
    app.ReverseString(text);
    Console.WriteLine(text);
  }

}
