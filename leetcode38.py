class Solution:
    # 1211 -> 111221
    def countAndSay(self, n: int) -> str:
        if n == 1:
            return "1"
        else:
            earlier = self.countAndSay(n - 1)
            if earlier == "1":
                return "11"
            result = ""
            i = 1
            temp = earlier[0]
            while i < len(earlier):
                number = earlier[i]
                if number == temp[0]:
                    temp += number
                else:
                    count = len(temp)
                    result += str(count) + str(temp[0])
                    temp = number
                i += 1
            count = len(temp)
            result += str(count) + str(temp[0])
            return result