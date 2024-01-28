/*
DIFFICULTY: Easy
QUESTION: 2574. Left and Right Sum Differences

Given a 0-indexed integer array nums, find a 0-indexed integer array answer
where:

    answer.length == nums.length.
    answer[i] = |leftSum[i] - rightSum[i]|.

Where:

    leftSum[i] is the sum of elements to the left of the index i in the array
    nums. If there is no such element, leftSum[i] = 0.
    rightSum[i] is the sum of elements to the right of the index i in the array
    nums. If there is no such element, rightSum[i] = 0.

Return the array answer.

APPROACH:
Calculate two cumulative sum arrays from left and right of the original nums
array and then do Math.Abs(arr1[i]-arr2[i]) for every index
*/

public class Solution
{
  public int[] LeftRightDifference(int[] nums)
  {
    int[] leftCumulativeSum = new int[nums.Length];
    int[] rightCumulativeSum = new int[nums.Length];
    int tempSum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      tempSum += nums[i];
      leftCumulativeSum[i] = tempSum;
    }
    tempSum = 0;
    for (int i = nums.Length - 1; i >= 0; i--)
    {
      tempSum += nums[i];
      rightCumulativeSum[i] = tempSum;
    }
    return leftCumulativeSum.Zip(
      rightCumulativeSum, (a, b) => Math.Abs(a - b)).ToArray();
  }
}
