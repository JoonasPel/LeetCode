# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3162. Find the Number of Good Pairs I
[*] DESCRIPTION:

You are given 2 integer arrays nums1 and nums2 of lengths n and m respectively. You are also given
a positive integer k.

A pair (i, j) is called good if nums1[i] is divisible by
nums2[j] * k (0 <= i <= n - 1, 0 <= j <= m - 1).

Return the total number of good pairs.

[*] INTUITION/APPROACH:
Precalculate nums2 elements * k and then loop all possible pairs and count good pairs.
[*] TIME COMPLEXITY: O(n*m)
[*] THOUGHTS:
Leetcode constraints have "1 <= nums1[i], nums2[j] <= 50", so zero division not checked.
"""

from typing import List
import time

class Solution:
    def numberOfPairs(self, nums1: List[int], nums2: List[int], k: int) -> int:
        nums2 = [num * k for num in nums2]
        good_pairs = 0
        for num1 in nums1:
            for num2 in nums2:
                if num1 % num2 == 0:
                    good_pairs += 1
        return good_pairs


t0 = time.time()
solution = Solution()
print(solution.numberOfPairs(list(range(1, 1000)), list(range(2, 1000)), 3))
print(time.time() - t0)
