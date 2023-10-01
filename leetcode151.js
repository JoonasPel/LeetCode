/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function(s) {
  const parts = s.split(/\s+/);
  if (parts.at(0) === '') { parts.shift(); }
  if (parts.at(-1) === '') { parts.pop(); }
  let result = '';
  for (let i=1; i<=parts.length; i++) {
    result += (parts.at(-1*i) + ' ');
  }
  return result.slice(0, -1);
};

console.log(reverseWords(s = "  a      good   example     "));