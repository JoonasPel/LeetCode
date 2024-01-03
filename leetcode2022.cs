using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2022. Convert 1D Array Into 2D Array

You are given a 0-indexed 1-dimensional (1D) integer array original, and two
integers, m and n. You are tasked with creating a 2-dimensional (2D) array with
m rows and n columns using all the elements from original.

The elements from indices 0 to n - 1 (inclusive) of original should form the
first row of the constructed 2D array, the elements from indices n to 2 * n - 1
(inclusive) should form the second row of the constructed 2D array, and so on.

Return an m x n 2D array constructed according to the above procedure, or an
empty 2D array if it is impossible.

APPROACH:
Check if original has correct amount of values in comparison to the target
2D array. If yes, create a new array and take subarrays from original array and
insert them into the 2D array.
*/

public class Solution
{

  public int[][] Construct2DArray(int[] original, int m, int n)
  {
    if (original.Length != m * n)
    {
      return new int[0][];
    }
    int[][] result = new int[m][];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
      result[i] = original[index..(index + n)];
      index += n;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
