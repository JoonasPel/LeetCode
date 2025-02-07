# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3392. Count Subarrays of Length Three With a Condition
[*] DESCRIPTION:
Given an integer array nums, return the number of subarrays of length 3 such that the sum of the
first and third numbers equals exactly half of the second number.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(n), n = length of nums
[*] THOUGHTS: -
"""

class Solution:
    def countSubarrays(self, nums: list[int]) -> int:
        valid_subarrs = 0
        for i in range(0, len(nums) - 2):
            if (nums[i] + nums[i + 2]) * 2 == nums[i + 1]:
                valid_subarrs += 1
        return valid_subarrs

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
    test(params=[[1, 2, 1, 4, 1]], answer=1)
    test(params=[[1, 1, 1]], answer=0)
    test(params=[[1, 1]], answer=0)
    test(params=[[1]], answer=0)
    test(params=[[]], answer=0)
