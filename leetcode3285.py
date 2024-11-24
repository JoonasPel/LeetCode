# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3285. Find Indices of Stable Mountains
[*] DESCRIPTION:
There are n mountains in a row, and each mountain has a height. You are given an integer array
height where height[i] represents the height of mountain i, and an integer threshold.
A mountain is called stable if the mountain just before it (if it exists) has a height strictly
greater than threshold. Note that mountain 0 is not stable.
Return an array containing the indices of all stable mountains in any order.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(n), n = number of mountains
[*] THOUGHTS: -
"""

from typing import List

class Solution:
    def stableMountains(self, height: List[int], threshold: int) -> List[int]:
        result = []
        for i in range(0, len(height) - 1):
            if height[i] > threshold:
                result.append(i + 1)
        return result


solution = Solution()
def test(a, b, answer):
    result = solution.stableMountains(a, b)
    if result != answer:
        print(f"Got {result} expected {answer} with {a}{b}")


if __name__ == "__main__":
    test([1, 2, 3, 4, 5], 2, [3, 4])
    test([10, 1, 10, 1, 10], 3, [1, 3])
