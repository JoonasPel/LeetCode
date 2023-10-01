/**
 * @param {number} n
 * @return {boolean}
 */
var isHappy = function(n) {
  let seenNumbers = new Set();
  let number = n;
  while (!seenNumbers.has(number)) {
    seenNumbers.add(number);
    number = Array.from(number.toString());
    let tempResult = 0;
    number.forEach(digit => {tempResult+=Math.pow(digit, 2)});
    number = tempResult;
    if (number === 1) {return true;}
  }
  return false;
};

console.log(isHappy(19));