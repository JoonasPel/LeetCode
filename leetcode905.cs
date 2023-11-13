using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 905. Sort Array By Parity

Given an integer array nums, move all the even integers at the beginning
of the array followed by all the odd integers.

Return any array that satisfies this condition.

APPROACH:
Start left ptr from the start of nums and right ptr from the end of nums.
Keep increasing left ptr until uneven number found. then keep decreasing the
right ptr until an even number is found and swap these. then move both ptrs
one step inner and keep doing the same until they are next to each other.

This approach is done in-place. doing it without in-place is faster when you
can just init a new array and put numbers there.
*/

public class Program
{

  public int[] SortArrayByParity(int[] nums)
  {
    int leftPtr = 0;
    int rightPtr = nums.Length - 1;
    while (leftPtr < rightPtr)
    {
      if (nums[leftPtr] % 2 != 0)
      {
        // find the next even from right to do swapping with uneven found left
        while (leftPtr < rightPtr)
        {
          if (nums[rightPtr] % 2 == 0)
          {
            (nums[leftPtr], nums[rightPtr]) = (nums[rightPtr], nums[leftPtr]);
            leftPtr++;
            rightPtr--;
            break;
          }
          else rightPtr--;
        }
      }
      else leftPtr++;
    }
    return nums;
  }

  public static void Main()
  {
  }
}
