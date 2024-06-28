/*
DIFFICULTY: Easy
QUESTION: 657. Robot Return to Origin

DESCRIPTION:
There is a robot starting at the position (0, 0), the origin, on a 2D plane.
Given a sequence of its moves, judge if this robot ends up at (0, 0) after it
completes its moves.

You are given a string moves that represents the move sequence of the robot
where moves[i] represents its ith move. Valid moves are 'R' (right),
'L' (left), 'U' (up), and 'D' (down).

Return true if the robot returns to the origin after it finishes all of its
moves, or false otherwise.

Note: The way that the robot is "facing" is irrelevant. 'R' will always make
the robot move to the right once, 'L' will always make it move left, etc. Also,
assume that the magnitude of the robot's movement is the same for each move.

INTUITION/APPROACH:
Keep track of x and y axis positions and check if they are zeroes at the end.
x and y are not dependent on each other.

TIME COMPLEXITY: O(n)

THOUGHTS:
*/

public class Solution
{
  public bool JudgeCircle(string moves)
  {
    int xPos = 0;
    int yPos = 0;
    foreach (char move in moves)
    {
      switch (move)
      {
        case 'U':
          yPos++;
          break;
        case 'D':
          yPos--;
          break;
        case 'L':
          xPos--;
          break;
        case 'R':
          xPos++;
          break;
        default:
          break;
      }
    }
    return xPos == 0 && yPos == 0;
  }

  public static void Main()
  {
  }
}
