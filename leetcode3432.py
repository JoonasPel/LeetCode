# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3432. Count Partitions with Even Sum Difference

[*] DESCRIPTION:
You are given an integer array nums of length n.
A partition is defined as an index i where 0 <= i < n - 1, splitting the array into two non-empty
subarrays such that:
    Left subarray contains indices [0, i].
    Right subarray contains indices [i + 1, n - 1].
Return the number of partitions where the difference between the sum of the left and right subarrays
is even.

[*] INTUITION/APPROACH: The sum of partitions is always even if the total sum is even.
[*] TIME COMPLEXITY: O(n), n = length of nums
[*] THOUGHTS: len(nums) - 1 bacause we can't make partition where other is full nums and other empty
"""

class Solution:
    def countPartitions(self, nums: list[int]) -> int:
        return len(nums) - 1 if sum(nums) % 2 == 0 else 0

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
    test([[10, 10, 3, 7, 6]], answer=4)
    test([[1, 2, 2]], answer=0)
    test([[2, 4, 6, 8,]], answer=3)
