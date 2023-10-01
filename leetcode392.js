/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 * O(s.length + t.length)
 */
var isSubsequence = function(s, t) {
  let ptrTidx = 0;
  let chFound = true;
  for (let ptrSIdx = 0; ptrSIdx<s.length; ptrSIdx++) {
    chFound = false;
    let ch = s[ptrSIdx];
    while (ptrTidx < t.length) {
      if (t[ptrTidx] === ch) {
        chFound = true;
        ptrTidx++;
        break;
      } else { ptrTidx++; }
    }
    if (!chFound) { return false; }
  }
  return chFound;
};

console.log(isSubsequence("aaaaaa", "bbaaaa"));