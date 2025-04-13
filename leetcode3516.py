# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Easy
[*] QUESTION: 3516. Find Closest Person

[*] DESCRIPTION:
You are given three integers x, y, and z, representing the positions of three people on
a number line:
    x is the position of Person 1.
    y is the position of Person 2.
    z is the position of Person 3, who does not move.
Both Person 1 and Person 2 move toward Person 3 at the same speed.
Determine which person reaches Person 3 first:
    Return 1 if Person 1 arrives first.
    Return 2 if Person 2 arrives first.
    Return 0 if both arrive at the same time.
Return the result accordingly.

[*] INTUITION/APPROACH:
[*] TIME COMPLEXITY: O(1)
[*] THOUGHTS:
"""

class Solution:
    def findClosest(self, x: int, y: int, z: int) -> int:
        dist_x = abs(x - z)
        dist_z = abs(y - z)
        if dist_x < dist_z:
            return 1
        if dist_x > dist_z:
            return 2
        return 0

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
    pass
