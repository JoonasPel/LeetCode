using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1337. The K Weakest Rows in a Matrix

You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's
(representing civilians). The soldiers are positioned in front of the
civilians. That is, all the 1's will appear to the left of all the 0's in each
row.

A row i is weaker than a row j if one of the following is true:

    The number of soldiers in row i is less than the number of soldiers in
    row j.
    Both rows have the same number of soldiers and i < j.

Return the indices of the k weakest rows in the matrix ordered from weakest to
strongest.

APPROACH:
Pretty bad solutions but saves the index and soldiers count of every row, then
sorts by soldiers count and if even, with index. Then returns k first.
*/


public class Solution
{

  public int[] KWeakestRows(int[][] mat, int k)
  {
    (int, int)[] rows = new (int, int)[mat.Length];
    for (int i = 0; i < mat.Length; i++)
    {
      int soldiers = 0;
      for (int j = 0; j < mat[0].Length; j++)
      {
        if (mat[i][j] == 1)
        {
          soldiers++;
        }
        else
        {
          break;
        }
      }
      rows[i] = (soldiers, i);
    }

    Array.Sort(rows, (a, b) =>
    {
      if (a.Item1 - b.Item1 < 0) return -1;
      if (a.Item1 - b.Item1 == 0) return a.Item2 - b.Item2;
      else return 1;
    });

    int[] result = new int[k];
    for (int i = 0; i < k; i++)
    {
      result[i] = rows[i].Item2;
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    int[][] jaggedArray = new int[][]
    {
      new int[] {1, 1, 0, 0, 0},
      new int[] {1, 1, 1, 1, 0},
      new int[] {1, 0, 0, 0, 0},
      new int[] {1, 1, 0, 0, 0},
      new int[] {1, 1, 1, 1, 1}
    };
    app.KWeakestRows(jaggedArray, 3);
  }
}
