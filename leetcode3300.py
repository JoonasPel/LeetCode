# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3300. Minimum Element After Replacement With Digit Sum
[*] DESCRIPTION:

You are given an integer array nums.
You replace each element in nums with the sum of its digits.
Return the minimum element in nums after all replacements.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n), n=nums length
[*] THOUGHTS:
Summing digits is usually done with "while num > 0" and "return result", but it seems to make
the solution ~10% slower. Looping to one digit and doing the additional addition
(return result + num) skips one unnecessary division. Seems to be pretty big difference.
"""

from typing import List
import time

class Solution:
    def __digitSum(self, num):
        result = 0
        while num > 9:
            result += num % 10
            num //= 10
        return result + num

    def minElement(self, nums: List[int]) -> int:
        smallest = float("inf")
        for num in nums:
            smallest = min(smallest, self.__digitSum(num))
        return smallest


solution = Solution()
t0 = time.time()
print(solution.minElement((list(range(5000000, 10000000)))))
print(time.time() - t0)
