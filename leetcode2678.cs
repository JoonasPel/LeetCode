using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2678. Number of Senior Citizens

You are given a 0-indexed array of strings details. Each element of details
provides information about a given passenger compressed into a string of
length 15. The system is such that:

    The first ten characters consist of the phone number of passengers.
    The next character denotes the gender of the person.
    The following two characters are used to indicate the age of the person.
    The last two characters determine the seat allotted to that person.

Return the number of passengers who are strictly more than 60 years old.

APPROACH:
Go through every detail and after parsing substring 11-12, check if it is >60
*/


public class Solution
{

  public int CountSeniors(string[] details)
  {
    int seniors = 0;
    foreach (string detail in details)
    {
      if (int.Parse(detail.Substring(11, 2)) > 60)
      {
        seniors++;
      }
    }
    return seniors;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
