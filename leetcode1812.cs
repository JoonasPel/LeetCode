/*
DIFFICULTY: Easy
QUESTION: 1812. Determine Color of a Chessboard Square

DESCRIPTION:
You are given coordinates, a string that represents the coordinates of a square
of the chessboard. Below is a chessboard for your reference.

INTUITION/APPROACH:
*/

public class Solution
{
  public bool SquareIsWhite(string coordinates)
  {
    return (coordinates[0] + char.GetNumericValue(coordinates[1])) % 2 != 0;
  }

  public static void Main()
  {
  }
}
