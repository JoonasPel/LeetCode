# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Medium
[*] QUESTION: 3016. Minimum Number of Pushes to Type Word II
[*] DESCRIPTION:
You are given a string word containing lowercase English letters.

Telephone keypads have keys mapped with distinct collections of lowercase English letters, which
can be used to form words by pushing them. For example, the key 2 is mapped with ["a","b","c"],
we need to push the key one time to type "a", two times to type "b", and three times to type "c" .

It is allowed to remap the keys numbered 2 to 9 to distinct collections of letters. The keys can be
remapped to any amount of letters, but each letter must be mapped to exactly one key. You need to
find the minimum number of times the keys will be pushed to type the string word.

Return the minimum number of pushes needed to type word after remapping the keys.

An example mapping of letters to keys on a telephone keypad is given below. Note that 1, *, #,
and 0 do not map to any letters.

[*] INTUITION/APPROACH:
Calculate the frequency of characters and then count their cost while "assigning" characters to
buttons, most frequent first. 8 most frequent characters will have cost 1 * frequency, 8 next chars
will have cost 2 * frequency, and so on.

[*] TIME COMPLEXITY: O(n), n=word length
    Sorting is O(n*logn) but the sorted items amount is limited to alphabet length in this case!
[*] THOUGHTS:
"""

from typing import List

class Solution:
    def minimumPushes(self, word: str) -> int:
        freqs = dict()
        for char in word:
            if char in freqs:
                freqs[char] += 1
            else:
                freqs[char] = 1
        sortedFreqs = sorted(freqs.items(), key=lambda x: x[1], reverse=True)
        totalCost = 0
        cost = 1
        buttonsUsed = 0
        for freq in sortedFreqs:
            buttonsUsed += 1
            if buttonsUsed == 9:
                cost += 1
                buttonsUsed = 1
            totalCost += freq[1] * cost
        return totalCost


solution = Solution()
def test(param, answer):
    result = solution.minimumPushes(param)
    if result != answer:
        print(f"Got {result} expected {answer} with {param}")


if __name__ == "__main__":
    test("aabbccddeeffgghhiiiiii", 24)
    test("alporfmdqsbhncwyu", 27)
