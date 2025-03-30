# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3498. Reverse Degree of a String

[*] DESCRIPTION:
Given a string s, calculate its reverse degree.
The reverse degree is calculated as follows:
    For each character, multiply its position in the reversed alphabet
    ('a' = 26, 'b' = 25, ..., 'z' = 1) with its position in the string (1-indexed).
    Sum these products for all characters in the string.
Return the reverse degree of s.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n), n = length of s
[*] THOUGHTS:
"""

class Solution:
    def reverseDegree(self, s: str) -> int:
        sum: int = 0
        for index, char in enumerate(s):
            sum += (index + 1) * (123 - ord(char))
        return sum

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
    test(["abc"], answer=148)
    test(["zaza"], answer=160)
