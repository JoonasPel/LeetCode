/**
 * @param {number} n
 * @return {string[]}
 */
var fizzBuzz = function(n) {
  let resultArr = [];
  let onlyNumber;
  for (let i=0; i<n; i++) {
    onlyNumber = true;

    if ((i+1) % 3 === 0) {
      resultArr[i] = "Fizz";
      onlyNumber = false;
    }
    if ((i+1) % 5 === 0) {
      if (resultArr[i]) {
        resultArr[i] = "FizzBuzz";
      } else {
        resultArr[i] = "Buzz";
      }
      onlyNumber = false;
    }
    if (onlyNumber) { resultArr.push((i+1).toString()); }
  }
  return resultArr;
};

console.log(fizzBuzz(3));