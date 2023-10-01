/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var maxVowels = function(s, k) {
  s = Array.from(s);
  const vowels = new Set(['a', 'e', 'i', 'o', 'u']);

  let tempSubString = s.slice(0, k);
  let currentVowelsInSubstring = 0;
  for (character of tempSubString) {
    if (vowels.has(character)) {
      currentVowelsInSubstring++;
    }
  }
  let maxVowelsFoundSoFar = currentVowelsInSubstring;
  let isNextCharVowel, isDroppedCharVowel;
  for (index=k; index<s.length; index++) {
    isNextCharVowel = vowels.has(s[index]);
    isDroppedCharVowel = vowels.has(s[index-k]);

    if (isNextCharVowel && !isDroppedCharVowel) {
      currentVowelsInSubstring++;
    } else if (!isNextCharVowel && isDroppedCharVowel) {
      currentVowelsInSubstring--;
    }

    maxVowelsFoundSoFar = Math.max(maxVowelsFoundSoFar, currentVowelsInSubstring);
    if (maxVowelsFoundSoFar === k) { return k; }
    
  }
  return maxVowelsFoundSoFar;  
};

console.log(maxVowels("abciiidef", 3));