# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 2894. Divisible and Non-divisible Sums Difference
[*] DESCRIPTION:

You are given positive integers n and m.
Define two integers as follows:
    num1: The sum of all integers in the range [1, n] (both inclusive) that are not divisible by m.
    num2: The sum of all integers in the range [1, n] (both inclusive) that are divisible by m.
Return the integer num1 - num2.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(n)
[*] THOUGHTS:
"""

class Solution:
    def differenceOfSums(self, n: int, m: int) -> int:
        result = 0
        for i in range(1, n + 1):
            if i % m == 0:
                result -= i
            else:
                result += i
        return result


solution = Solution()
def test(n, m, answer):
    result = solution.differenceOfSums(n, m)
    if result != answer:
        print(f"Got {result} expected {answer} with {n} {m}")


if __name__ == "__main__":
    test(10, 3, 19)
    test(5, 6, 15)
    test(5, 1, -15)
