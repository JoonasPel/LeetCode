# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3502. Minimum Cost to Reach Every Position

[*] DESCRIPTION:
You are given an integer array cost of size n. You are currently at position n
(at the end of the line) in a line of n + 1 people (numbered from 0 to n).
You wish to move forward in the line, but each person in front of you charges a specific amount to
swap places. The cost to swap with person i is given by cost[i].
You are allowed to swap places with people as follows:
    If they are in front of you, you must pay them cost[i] to swap with them.
    If they are behind you, they can swap with you for free.
Return an array answer of size n, where answer[i] is the minimum total cost to reach each position i
in the line.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n), n = length of cost
[*] THOUGHTS: Nightmare description
"""

class Solution:
    def minCosts(self, cost: list[int]) -> list[int]:
        result: list[int] = []
        temp_min = cost[0]
        for num in cost:
            temp_min = min(temp_min, num)
            result.append(temp_min)
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
    test([[5, 3, 4, 1, 3, 2]], answer=[5, 3, 3, 1, 1, 1])
    test([[1, 2, 4, 6, 7]], answer=[1, 1, 1, 1, 1])
