/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function(ransomNote, magazine) {
  let letters = new Map();
  for (let ch of magazine) {
    let amount = letters.get(ch) ?? 0;
    letters.set(ch, amount + 1);
  }
  for (let ch of ransomNote) {
    let amount = letters.get(ch) ?? 0;
    if (amount === 0) { return false; }
    letters.set(ch, amount - 1); 
  }
  return true;
};

console.log(canConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));