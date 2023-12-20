using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1051. Height Checker

A school is trying to take an annual photo of all the students. The students
are asked to stand in a single file line in non-decreasing order by height.
Let this ordering be represented by the integer array expected where
expected[i] is the expected height of the ith student in line.

You are given an integer array heights representing the current order that the
students are standing in. Each heights[i] is the height of the ith student in
line (0-indexed).

Return the number of indices where heights[i] != expected[i].

APPROACH:
Create a copy of the heights array and sort it. Then just check how many
items in the same indices are different.
*/


public class Solution
{

  public int HeightChecker(int[] heights)
  {
    int[] sortedHeights = new int[heights.Length];
    heights.CopyTo(sortedHeights, 0);
    Array.Sort(sortedHeights);
    int different = 0;
    for (int i = 0; i < heights.Length; i++)
    {
      if (heights[i] != sortedHeights[i]) different++;
    }
    return different;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
