"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3289. The Two Sneaky Numbers of Digitville
[*] DESCRIPTION:

In the town of Digitville, there was a list of numbers called nums containing integers from 0 to
n - 1. Each number was supposed to appear exactly once in the list, however, two mischievous numbers
sneaked in an additional time, making the list longer than usual.

As the town detective, your task is to find these two sneaky numbers. Return an array of size two
containing the two numbers (in any order), so peace can return to Digitville.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n)
[*] THOUGHTS:
-
"""

from typing import List

class Solution:
    def getSneakyNumbers(self, nums: List[int]) -> List[int]:
        seen = set()
        sneaky_nums = []
        for num in nums:
            if num in seen:
                sneaky_nums.append(num)
            seen.add(num)
        return sneaky_nums
