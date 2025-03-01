# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3349. Adjacent Increasing Subarrays Detection I

[*] DESCRIPTION:
Given an array nums of n integers and an integer k, determine whether there exist two adjacent

of length k such that both subarrays are strictly increasing. Specifically, check if there are two
subarrays starting at indices a and b (a < b), where:

    Both subarrays nums[a..a + k - 1] and nums[b..b + k - 1] are strictly increasing.
    The subarrays must be adjacent, meaning b = a + k.

Return true if it is possible to find two such subarrays, and false otherwise.

[*] INTUITION/APPROACH: Keep Set of indexes that are end of increasing k-length array. When found
another, check if there is a pair. For example [2, 5, 7, 8, 9, 2, 3, 4, 3, 1] will create set
{2,3,4} and then at index 7 "match" is found. (7,8,9) and (2,3,4) 
[*] TIME COMPLEXITY: O(n), n = length of nums.
[*] THOUGHTS: Pretty difficult
"""

class Solution:
    def hasIncreasingSubarrays(self, nums: list[int], k: int) -> bool:
        if len(nums) < 3:  # special cases
            return True
        incr_arrs_last_idx = set()
        incs_in_row = 1
        for i in range(1, len(nums)):
            if nums[i] > nums[i - 1]:
                incs_in_row += 1
            else:
                incs_in_row = 1
            if incs_in_row >= k:
                incr_arrs_last_idx.add(i)
                if incs_in_row == 2 * k or (i - k) in incr_arrs_last_idx:
                    return True
        return False

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
    test([[2, 5, 7, 8, 9, 2, 3, 4, 3, 1], 3], answer=True)
    test([[1, 2, 3, 4, 4, 4, 4, 5, 6, 7], 5], answer=False)
    test([[19, 5], 1], answer=True)
