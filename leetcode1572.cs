using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1572. Matrix Diagonal Sum

Given a square matrix mat, return the sum of the matrix diagonals.

Only include the sum of all the elements on the primary diagonal and all the
elements on the secondary diagonal that are not part of the primary diagonal.

APPROACH:
Go through the rows and with two different index "pointers" starting from both
the first and last column, add values to sum and then move other pointer one
step right and other one step left. If the "pointers" point to same value, add
it only once to the sum.
*/


public class Solution
{

  public int DiagonalSum(int[][] mat)
  {
    int sum = 0;
    int i = 0;
    int j = mat.Length - 1;
    foreach (int[] row in mat)
    {
      sum += row[i];
      if (i != j) sum += row[j];
      i++;
      j--;
    }
    return sum;
  }

  public static void Main()
  {
  }
}
