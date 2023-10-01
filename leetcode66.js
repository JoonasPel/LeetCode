/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function(digits) {
  let temp;
  let length = digits.length;
  for (let idx=-1; idx>=-digits.length; idx--) {
    temp = digits.at(idx) + 1;
    if (temp < 10) {
      digits[length+idx] = temp;
      return digits;
    } else {
      digits[length+idx] = 0;
    }
  }
  digits.unshift(1);
  return digits;
};

console.log(plusOne([9,9,9,9]));