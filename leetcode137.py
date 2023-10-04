class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        seen_once = set()
        seen_twice = set()
        seen_3times = set()
        for num in nums:
            if num in seen_once:
                seen_twice.add(num)
                seen_once.remove(num)
            elif num in seen_twice:
                seen_3times.add(num)
                seen_twice.remove(num)
            else:
                seen_once.add(num)
        return next(iter(seen_once))
