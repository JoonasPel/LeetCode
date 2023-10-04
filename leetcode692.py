class Solution:
    def topKFrequent(self, words: List[str], k: int) -> List[str]:
        
        # key = word, value = occurance count
        words_dict = {}    
        for word in words:
            words_dict[word] = words_dict.get(word, 0) + 1
                
        words_dict = {k: v for k, v in sorted(words_dict.items(), key=lambda x: (-x[1], x[0]))}
        return list(words_dict.keys())[:k]
