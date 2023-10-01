/**
 * @param {string} columnTitle
 * @return {number}
 */
var titleToNumber = function(columnTitle) {
  columnTitle = columnTitle.split("").reverse().join("");
  let resultNumber = 0;
  let x = 0;
  for (let ch of columnTitle) {
    resultNumber += Math.pow(26, x) * (ch.charCodeAt(0) - 64);
    x++;
  };
  return resultNumber;
};

console.log(titleToNumber("ZZZ"));