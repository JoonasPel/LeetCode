# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3442. Maximum Difference Between Even and Odd Frequency I
[*] DESCRIPTION:
You are given a string s consisting of lowercase English letters. Your task is to find the maximum
difference between the frequency of two characters in the string such that:
    One of the characters has an even frequency in the string.
    The other character has an odd frequency in the string.
Return the maximum difference, calculated as the frequency of the character with an odd frequency
minus the frequency of the character with an even frequency.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(n), n = length of s
[*] THOUGHTS: -
"""
from collections import Counter

class Solution:
    def maxDifference(self, s: str) -> int:
        freqs = Counter(s)
        minOdd, maxOdd, minEven, maxEven = 1000000, -1, 100000, -1
        for _, freq in freqs.items():
            if freq % 2 == 0:
                minEven = min(minEven, freq)
                maxEven = max(maxEven, freq)
            else:
                minOdd = min(minOdd, freq)
                maxOdd = max(maxOdd, freq)
        return max((minOdd - maxEven), (maxOdd - minEven))

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
    test(params=["aaaaabbc"], answer=3)
    test(params=["abcabcab"], answer=1)
    test(params=["tzt"], answer=-1)
