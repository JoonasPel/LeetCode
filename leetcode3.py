def lengthOfLongestSubstring(s: str) -> int:
    best_len_so_far = 0
    temp = ""
    for letter in s:
        if letter not in temp:
            temp += letter
        else:
            if len(temp) > best_len_so_far:
                best_len_so_far = len(temp)

            i = temp.find(letter)
            temp = temp[i+1:] + letter
    if len(temp) > best_len_so_far:
        return len(temp)
    else:
        return best_len_so_far


if __name__ == '__main__':
    s = " "
    print(lengthOfLongestSubstring(s))
