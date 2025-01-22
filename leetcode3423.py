# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3423. Maximum Difference Between Adjacent Elements in a Circular Array
[*] DESCRIPTION:
Given a circular array nums, find the maximum absolute difference between adjacent elements.
Note: In a circular array, the first and last elements are adjacent.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(n), n = nums length
[*] THOUGHTS: -
"""
from typing import List

class Solution:
    def maxAdjacentDistance(self, nums: List[int]) -> int:
        diff = 0
        for i in range(0, len(nums) - 1):
            diff = max(diff, abs(nums[i] - nums[i + 1]))
        return max(diff, abs(nums[0] - nums[-1]))

    # used for testing
    def __call__(self, params):
        method = [m for m in dir(self) if callable(getattr(self, m)) and not m.startswith("_")]
        assert len(method) == 1, f"Only one public method allowed. Found {len(method)}"
        return getattr(self, method[0])(*params)


solution = Solution()
# used for testing
def test(params, answer):
    result = solution(params)
    if result != answer:
        print(f"Got {result} expected {answer} with params:", *params)


if __name__ == "__main__":
    test(params=[[1, 2, 4]], answer=3)
    test(params=[[-5, -10, -5]], answer=5)
