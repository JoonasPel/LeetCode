# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3512. Minimum Operations to Make Array Sum Divisible by K

[*] DESCRIPTION:
You are given an integer array nums and an integer k. You can perform the following operation
any number of times:
    Select an index i and replace nums[i] with nums[i] - 1.
Return the minimum number of operations required to make the sum of the array divisible by k.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n), n = length of nums
[*] THOUGHTS:
"""

class Solution:
    def minOperations(self, nums: list[int], k: int) -> int:
        total_sum: int = sum(nums)
        if total_sum < k:
            return total_sum
        if total_sum == k:
            return 0
        if total_sum > k:
            return total_sum % k

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
    pass
