# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3402. Minimum Operations to Make Columns Strictly Increasing
[*] DESCRIPTION:
You are given a m x n matrix grid consisting of non-negative integers.
In one operation, you can increment the value of any grid[i][j] by 1.
Return the minimum number of operations needed to make all columns of grid strictly increasing.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(m*n), m = rows, n = columns
[*] THOUGHTS: -
"""
from typing import List

class Solution:
    def minimumOperations(self, grid: List[List[int]]) -> int:
        result = 0
        for j in range(0, len(grid[0])):
            earlier = grid[0][j]
            for i in range(1, len(grid)):
                if grid[i][j] <= earlier:
                    result += earlier + 1 - grid[i][j]
                    earlier += 1
                else:
                    earlier = grid[i][j]
        return result

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
    test(params=[[[3, 2], [1, 3], [3, 4], [0, 1]]], answer=15)
    test(params=[[[3, 2, 1], [2, 1, 0], [1, 2, 3]]], answer=12)
