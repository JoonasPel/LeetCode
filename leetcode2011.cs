﻿/*
DIFFICULTY: Easy
QUESTION: 2011. Final Value of Variable After Performing Operations

DESCRIPTION:
There is a programming language with only four operations and one variable X:

    ++X and X++ increments the value of the variable X by 1.
    --X and X-- decrements the value of the variable X by 1.

Initially, the value of X is 0.

Given an array of strings operations containing a list of operations, return
the final value of X after performing all the operations.

INTUITION/APPROACH:
*/

public class Solution
{
  public int FinalValueAfterOperations(string[] operations)
  {
    int init = 0;
    foreach (string operation in operations)
    {
      if (operation[1] == '+') init++;
      else init--;
    }
    return init;
  }
}
