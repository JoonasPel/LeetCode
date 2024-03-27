/*
DIFFICULTY: Easy
QUESTION: 509. Fibonacci Number

DESCRIPTION:
The Fibonacci numbers, commonly denoted F(n) form a sequence, called the
Fibonacci sequence, such that each number is the sum of the two preceding ones,
starting from 0 and 1. That is,

F(0) = 0, F(1) = 1
F(n) = F(n - 1) + F(n - 2), for n > 1.

Given n, calculate F(n).

INTUITION/APPROACH:
*/


public class Solution
{
  public int Fib(int n)
  {
    if (n == 0) return 0;
    if (n == 1) return 1;
    return Fib(n - 1) + Fib(n - 2);
  }

  public static void Main()
  {
  }
}

