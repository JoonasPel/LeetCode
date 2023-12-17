using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2951. Find the Peaks

You are given a 0-indexed array mountain. Your task is to find all the peaks
in the mountain array.

Return an array that consists of indices of peaks in the given array in any
order.

Notes:

    A peak is defined as an element that is strictly greater than its
    neighboring elements.
    The first and last elements of the array are not a peak.

APPROACH:
Loop the array from index 1 to Length-2 because the edges cant be peaks.
Save both neighbours to a variable and check if the current index is a peak
and if yes, save it to peaks List. When a peak is found, increase index by 2
instead of 1 because the next one cant be peak. Cant have two peaks side by side
*/


public class Solution
{

  public IList<int> FindPeaks(int[] mountain)
  {
    IList<int> peaks = new List<int>();
    int leftNeighborHeight = mountain[0];
    int rightNeighborHeight;
    int currentHeight;
    for (int i = 1; i < mountain.Length - 1;)
    {
      currentHeight = mountain[i];
      rightNeighborHeight = mountain[i + 1];
      if (currentHeight > leftNeighborHeight
      && currentHeight > rightNeighborHeight)
      {
        peaks.Add(i);
        leftNeighborHeight = rightNeighborHeight;
        i += 2;
      }
      else
      {
        i++;
        leftNeighborHeight = currentHeight;
      }
    }
    return peaks;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
