/**
 * @param {number} n
 * @return {boolean}
 */
var isPowerOfThree = function(n) {
  if (n === 0) { return false; }
  while (Number.isInteger(n)) {
    if (n === 1) { return true; }
    n /= 3;
  }
  return false;
};