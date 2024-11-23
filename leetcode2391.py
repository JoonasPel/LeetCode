# pylint: disable=C0115, C0116, C0103
"""
[*] DIFFICULTY: Medium
[*] QUESTION: 2391. Minimum Amount of Time to Collect Garbage
[*] DESCRIPTION:
You are given a 0-indexed array of strings garbage where garbage[i] represents the assortment of
garbage at the ith house. garbage[i] consists only of the characters 'M', 'P' and 'G' representing
one unit of metal, paper and glass garbage respectively. Picking up one unit of any type of garbage
takes 1 minute.
You are also given a 0-indexed integer array travel where travel[i] is the number of minutes needed
to go from house i to house i + 1.
There are three garbage trucks in the city, each responsible for picking up one type of garbage.
Each garbage truck starts at house 0 and must visit each house in order; however, they do not need
to visit every house.
Only one garbage truck may be used at any given moment. While one truck is driving or picking up
garbage, the other two trucks cannot do anything.
Return the minimum number of minutes needed to pick up all the garbage.

[*] INTUITION/APPROACH:
Count the garbages and last house of specific garbage type as the truck doesn't go further.
[*] TIME COMPLEXITY: O(n*m), n=number of houses, m=average number of garbage in one house
[*] THOUGHTS:
"""

from typing import List

class Solution:
    def garbageCollection(self, garbage: List[str], travel: List[int]) -> int:
        garbageAmounts = {"G": 0, "P": 0, "M": 0}
        lastHouseWithSpecificGarbage = {"G": 0, "P": 0, "M": 0}
        totalGarbage = 0
        currentHouse = -1
        for garb in garbage:
            currentHouse += 1
            for char in garb:
                totalGarbage += 1
                garbageAmounts[char] += 1
                lastHouseWithSpecificGarbage[char] = currentHouse
        totalTravel = 0
        for index, value in enumerate(travel):
            if lastHouseWithSpecificGarbage["G"] > index:
                totalTravel += value
            if lastHouseWithSpecificGarbage["P"] > index:
                totalTravel += value
            if lastHouseWithSpecificGarbage["M"] > index:
                totalTravel += value
        return totalGarbage + totalTravel


solution = Solution()
def test(n, m, answer):
    result = solution.garbageCollection(n, m)
    if result != answer:
        print(f"Got {result} expected {answer} with {n} {m}")


if __name__ == "__main__":
    test(["G", "P", "GP", "GG"], [2, 4, 3], 21)
    test(["MMM", "PGM", "GP"], [3, 10], 37)
