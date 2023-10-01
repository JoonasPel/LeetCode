/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function(pattern, s) {
  let patt = [];
  let letters = new Map();
  let j = 0;
  for (let ch of pattern) {
    if (!letters.has(ch)) {
      letters.set(ch, j);
      j++;
    }
    patt.push(letters.get(ch));
  }
  console.log(patt)
  let words = s.split(' ');
  let wordPattern = new Map();
  let index = -1;
  let i = 0;
  for (let word of words) {
    index++;
    let num = wordPattern.get(word);
    if (num === undefined) {
      wordPattern.set(word, i);
      num = i;
      i++;
    }
    if (patt[index] !== num) { return false; }
  }
  return patt.length === words.length;
};

console.log(wordPattern(pattern = "jquery", s = "jquery"));