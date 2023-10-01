/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
  let seenNums = new Set();
  for (let num of nums) {
    if (seenNums.has(num)) {return true;}
    seenNums.add(num);
  }
  return false;  
};

console.log(containsDuplicate([1,1,1,3,3,4,3,2,4,2]));