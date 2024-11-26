# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 2520. Count the Digits That Divide a Number
[*] DESCRIPTION:
Given an integer num, return the number of digits in num that divide num.
An integer val divides nums if nums % val == 0.

[*] INTUITION/APPROACH: -
[*] TIME COMPLEXITY: O(n), n = number of digits in num
[*] THOUGHTS: -
"""

class Solution:
    def countDigits(self, num: int) -> int:
        result = 0
        originalNum = num
        while num > 0:
            if originalNum % (num % 10) == 0:
                result += 1
            num //= 10
        return result

    def __call__(self, params):
        method = [m for m in dir(self) if callable(getattr(self, m)) and not m.startswith("_")]
        assert len(method) == 1, f"Only one public method allowed. Found {len(method)}"
        return getattr(self, method[0])(*params)


solution = Solution()
def test(params, answer):
    result = solution(params)
    if result != answer:
        print(f"Got {result} expected {answer} with params:", *params)


if __name__ == "__main__":
    test(params=[2], answer=1)
    test(params=[121], answer=2)
    test(params=[1248], answer=4)
