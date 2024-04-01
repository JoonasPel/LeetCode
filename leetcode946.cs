/*
DIFFICULTY: Medium
QUESTION: 946. Validate Stack Sequences

DESCRIPTION:
Given two integer arrays pushed and popped each with distinct values,
return true if this could have been the result of a sequence of push
and pop operations on an initially empty stack, or false otherwise.

INTUITION/APPROACH:
Always try to pop a number from the stack if the number is correct
in comparison to popped array. If not, push a new number from pushed
array and repeat. Sequence is valid if we can reach the end of both
pushed and popped arrays doing this.
*/


public class Solution
{
  public bool ValidateStackSequences(int[] pushed, int[] popped)
  {
    int pushIdx = 0;
    int popIdx = 0;
    Stack<int> stack = new();
    while (true)
    {
      if (stack.TryPeek(out int num) && num == popped[popIdx])
      {
        stack.Pop();
        popIdx++;
      }
      else if (pushIdx < pushed.Length)
      {
        stack.Push(pushed[pushIdx++]);
      }
      else break;
    }
    return pushIdx == pushed.Length && popIdx == popped.Length;
  }

  public static void Main()
  {
  }
}
