"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3190. Find Minimum Operations to Make All Elements Divisible by Three
[*] DESCRIPTION:
You are given an integer array nums. In one operation, you can add or subtract 1 from
any element of nums.
Return the minimum number of operations to make all elements of nums divisible by 3.

[*] INTUITION/APPROACH:
Number can always be made to divisible by 3 with 0 or 1 operations by keeping it the same or
summing or substracing 1. Can be checked from the remainder.
[*] TIME COMPLEXITY: O(n)
[*] THOUGHTS:
-
"""

from typing import List

class Solution:
    def minimumOperations(self, nums: List[int]) -> int:
        operations = 0
        for num in nums:
            if num % 3 != 0:
                operations += 1
        return operations
