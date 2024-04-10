/*
DIFFICULTY: Easy
QUESTION: 2798. Number of Employees Who Met the Target

DESCRIPTION:
There are n employees in a company, numbered from 0 to n - 1. Each employee i
has worked for hours[i] hours in the company.

The company requires each employee to work for at least target hours.

You are given a 0-indexed array of non-negative integers hours of length n and
a non-negative integer target.

Return the integer denoting the number of employees who worked at least target
hours.

INTUITION/APPROACH:
*/


public class Solution
{
  public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
  {
    int result = 0;
    foreach (int hour in hours)
    {
      if (hour >= target) result++;
    }
    return result;
  }

  public static void Main()
  {
  }
}
