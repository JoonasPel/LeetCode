using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2125. Number of Laser Beams in a Bank

Anti-theft security devices are activated inside a bank. You are given
a 0-indexed binary string array bank representing the floor plan of
the bank, which is an m x n 2D matrix. bank[i] represents the ith row,
consisting of '0's and '1's. '0' means the cell is empty, while'1'
means the cell has a security device.

There is one laser beam between any two security devices if both
conditions are met:

    The two devices are located on two different rows: r1 and r2,
    where r1 < r2.
    For each row i where r1 < i < r2, there are no security devices in
    the ith row.

Laser beams are independent, i.e., one beam does not interfere nor
join with another.

Return the total number of laser beams in the bank.

APPROACH:
Go through the rows and increment total lasers count by multiplying
the device amount of a row by the earlier device count before that row
*/


public class Solution
{
  public int NumberOfBeams(string[] bank)
  {
    int laserBeams = 0;
    int earlierRowDevices = 0;
    foreach (string row in bank)
    {
      int devices = row.Count(c => c == '1');
      if (devices > 0)
      {
        laserBeams += devices * earlierRowDevices;
        earlierRowDevices = devices;
      }
    }
    return laserBeams;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.NumberOfBeams(
      new string[] { "011001", "000000", "010100", "001000" }));
  }
}
