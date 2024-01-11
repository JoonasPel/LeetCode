using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 832. Flipping an Image

Given an n x n binary matrix image, flip the image horizontally, then invert
it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.

    For example, flipping [1,1,0] horizontally results in [0,1,1].

To invert an image means that each 0 is replaced by 1, and each 1 is replaced
by 0.

    For example, inverting [0,1,1] results in [1,0,0].

APPROACH:
Loop the rows and swap the ith first and ith last item and also invert the num.
After the row is done, check if it is odd and if yes, invert middle num too.
*/

public class Solution
{
  public int[][] FlipAndInvertImage(int[][] image)
  {
    foreach (int[] row in image)
    {
      for (int i = 0; i < row.Length / 2; i++)
      {
        if (row[i] == 0) row[i] = 1;
        else row[i] = 0;
        if (row[^(i + 1)] == 0) row[^(i + 1)] = 1;
        else row[^(i + 1)] = 0;
        (row[i], row[^(i + 1)]) = (row[^(i + 1)], row[i]);
      }
      // invert middle if exists (odd number of items)
      if (row.Length % 2 != 0)
      {
        if (row[row.Length / 2] == 0)
        {
          row[row.Length / 2] = 1;
        }
        else
        {
          row[row.Length / 2] = 0;
        }
      }
    }
    return image;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
