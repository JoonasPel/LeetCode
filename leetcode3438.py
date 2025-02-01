# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3438. Find Valid Pair of Adjacent Digits in String
[*] DESCRIPTION:
You are given a string s consisting only of digits. A valid pair is defined as two adjacent digits
in s such that:
    The first digit is not equal to the second.
    Each digit in the pair appears in s exactly as many times as its numeric value.
Return the first valid pair found in the string s when traversing from left to right. If no valid
pair exists, return an empty string.

[*] INTUITION/APPROACH: Create frequencies dict, loop digits again and find first valid pair.
[*] TIME COMPLEXITY: O(n), n = length of s
[*] THOUGHTS: -
"""
from collections import Counter

class Solution:
    def findValidPair(self, s: str) -> str:
        freqs = Counter(s)
        earlierValid = False
        earlierDigit = ""
        for digit in s:
            valid = freqs[digit] == int(digit)
            if digit != earlierDigit and valid and earlierValid:
                return earlierDigit + digit
            earlierDigit, earlierValid = digit, valid
        return ""

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
    test(params=["2523533"], answer="23")
    test(params=["221"], answer="21")
    test(params=["22"], answer="")
