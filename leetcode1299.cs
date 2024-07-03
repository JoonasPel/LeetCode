/*
DIFFICULTY: Easy
QUESTION: 1299. Replace Elements with Greatest Element on Right Side

DESCRIPTION:
Given an array arr, replace every element in that array with the greatest
element among the elements to its right, and replace the last element with -1.

After doing so, return the array.

INTUITION/APPROACH:
Start from the end of array and keep track of the greatest num found. Replace
numbers with that.

TIME COMPLEXITY: O(n)

THOUGHTS:
*/

public class Solution
{
  public int[] ReplaceElements(int[] arr)
  {
    int greatestSoFar = -1;
    for (int i = arr.Length - 1; i >= 0; i--)
    {
      (arr[i], greatestSoFar) = (greatestSoFar, Math.Max(greatestSoFar, arr[i]));
    }
    return arr;
  }

  public static void Main()
  {
  }
}
