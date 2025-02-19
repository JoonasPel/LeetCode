# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3456. Find Special Substring of Length K

[*] DESCRIPTION:
You are given a string s and an integer k.
Determine if there exists a substring of length exactly k in s that satisfies the following conditions:
    1. The substring consists of only one distinct character (e.g., "aaa" or "bbb").
    2. If there is a character immediately before the substring, it must be different from the
    character in the substring.
    3. If there is a character immediately after the substring, it must also be different from the
    character in the substring.
Return true if such a substring exists. Otherwise, return false. 

[*] INTUITION/APPROACH: Keep counter how many same chars are in row and when encountered different
char or string ends, return True if counter is correct (k). Counter checks the "char immediately before
the substring" condition, as it wouldn't match otherwise. For example:
s: "aaaab", k=3 parameters return False as the counter is 4 not 3, when b is encountered.
[*] TIME COMPLEXITY: O(n), n = length of s
[*] THOUGHTS: Fun
"""

class Solution:
    def hasSpecialSubstring(self, s: str, k: int) -> bool:
        earlier_char = ""
        counter = 0
        for char in s:
            if char != earlier_char:
                if counter == k:
                    return True
                counter = 1
                earlier_char = char
            else:
                counter += 1
        return counter == k

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
    test(params=["aaabaaa", 3], answer=True)
    test(params=["abc", 2], answer=False)
    test(params=["aaaab", 3], answer=False)
