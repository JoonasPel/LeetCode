# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3407. Substring Matching Pattern
[*] DESCRIPTION:
You are given a string s and a pattern string p, where p contains exactly one '*' character.
The '*' in p can be replaced with any sequence of zero or more characters.
Return true if p can be made a substring of s, and false otherwise.

[*] INTUITION/APPROACH: * can be replace as .* which is regex pattern meaning 0 or more of anything
[*] TIME COMPLEXITY: O(n+m), n = length of s, m = length of p
[*] THOUGHTS: -
"""

import re

class Solution:
    def hasMatch(self, s: str, p: str) -> bool:
        return re.search(p.replace("*", ".*"), s) is not None

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
    test(params=["leetcode", "ee*e"], answer=True)
    test(params=["car", "c*v"], answer=False)
    test(params=["luck", "u*"], answer=True)
