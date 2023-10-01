var firstUniqChar = function(s) {
  let seen = new Set();
  for (let i=0;i<s.length;i++){
    let character=s[i]
    if (!seen.has(character)) {
      seen.add(character);
      if (s.indexOf(character)==i && s.indexOf(character,i+1)==-1){
        return i
      }
    }
  }
  return -1
};

console.log(firstUniqChar("leetcode"));
