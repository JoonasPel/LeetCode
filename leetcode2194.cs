/*
DIFFICULTY: Easy
QUESTION: 2194. Cells in a Range on an Excel Sheet

DESCRIPTION:
A cell (r, c) of an excel sheet is represented as a string "<col><row>" where:

    <col> denotes the column number c of the cell. It is represented byalphabetical letters.
        For example, the 1st column is denoted by 'A', the 2nd by 'B', the 3rd by 'C', and so on.
    <row> is the row number r of the cell. The rth row is represented by the integer r.

You are given a string s in the format "<col1><row1>:<col2><row2>", where <col1>
represents the column c1, <row1> represents the row r1, <col2> represents the
column c2, and <row2> represents the row r2, such that r1 <= r2 and c1 <= c2.

Return the list of cells (x, y) such that r1 <= x <= r2 and c1 <= y <= c2. The
cells should be represented as strings in the format mentioned above and be
sorted in non-decreasing order first by columns and then by rows.

INTUITION/APPROACH:
*/

public class Solution
{
  public IList<string> CellsInRange(string s)
  {
    IList<string> cells = new List<string>();
    char c0 = s[0];
    char c1 = s[3];
    while (c0 <= c1)
    {
      int num0 = s[1] - 48;
      int num1 = s[4] - 48;
      while (num0 <= num1)
      {
        cells.Add($"{c0}{num0}");
        num0++;
      }
      c0++;
    }
    return cells;
  }

  public static void Main()
  {
    Solution app = new();
    app.CellsInRange("K1:L2");
  }
}
