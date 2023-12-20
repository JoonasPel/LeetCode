using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2089. Find Target Indices After Sorting Array

You are given a 0-indexed integer array nums and a target element target.

A target index is an index i such that nums[i] == target.

Return a list of the target indices of nums after sorting nums in
non-decreasing order. If there are no target indices, return an empty list.
The returned list must be sorted in increasing order.


APPROACH:
Order nums and then find any occurance of the target with binary search.
Then go backwards and forwards from the occurance (index) and find all other
occurances.

PERFORMANCE:
Runtime: Beats 100% of users with C#. New record 108ms -> 100ms.
Memory:  Beats 5.4% of users with C#
*/


public class Solution
{

  public IList<int> TargetIndices(int[] nums, int target)
  {
    Array.Sort(nums);
    int indexOfSomeOccurance = Array.BinarySearch(nums, target);
    IList<int> result = new List<int>();
    if (indexOfSomeOccurance < 0)
    {
      return result;
    }
    else
    {
      result.Add(indexOfSomeOccurance);
      int index = indexOfSomeOccurance;
      while (index > 0)
      {
        index--;
        if (nums[index] == target)
        {
          result.Add(index);
        }
        else
        {
          break;
        }
      }
      index = indexOfSomeOccurance;
      while (index < nums.Length - 1)
      {
        index++;
        if (nums[index] == target)
        {
          result.Add(index);
        }
        else
        {
          break;
        }
      }
    }
    return result.Order().ToList();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
