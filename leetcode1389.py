# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 1389. Create Target Array in the Given Order
[*] DESCRIPTION:

Given two arrays of integers nums and index. Your task is to create target array under
the following rules:

    Initially target array is empty.
    From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in
    target array. Repeat the previous step until there are no elements to read in nums and index.

Return the target array.

It is guaranteed that the insertion operations will be valid.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n^2), n=nums/index length
[*] THOUGHTS:
"""

from typing import List

class Solution:
    def createTargetArray(self, nums: List[int], index: List[int]) -> List[int]:
        target = []
        for idx, val in enumerate(nums):
            target.insert(index[idx], val)
        return target
