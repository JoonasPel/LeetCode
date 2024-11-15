# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3194. Minimum Average of Smallest and Largest Elements
[*] DESCRIPTION:

You have an array of floating point numbers averages which is initially empty. You are given an
array nums of n integers where n is even.

You repeat the following procedure n / 2 times:

    Remove the smallest element, minElement, and the largest element maxElement, from nums.
    Add (minElement + maxElement) / 2 to averages.

Return the minimum element in averages.

[*] INTUITION/APPROACH:
Sort and then find smallest avg with two index pointers.
[*] TIME COMPLEXITY: O(n*log(n))
[*] THOUGHTS: -
"""

from typing import List

class Solution:
    def minimumAverage(self, nums: List[int]) -> float:
        smallest = 100000
        nums.sort()
        leftPtr = 0
        rightPtr = len(nums) - 1
        while leftPtr < rightPtr:
            avg = (nums[leftPtr] + nums[rightPtr]) / 2
            smallest = min(smallest, avg)
            leftPtr += 1
            rightPtr -= 1
        return smallest


solution = Solution()
print(solution.minimumAverage([1, 9, 8, 3, 10, 5]))
