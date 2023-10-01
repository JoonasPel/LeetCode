/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
  const n = nums.length;
  let notSeenNums = new Set();
  for (let i=0; i<=n; i++) {
    notSeenNums.add(i);
  }
  for (let num of nums) {
    notSeenNums.delete(num);
  }
  return notSeenNums.values().next().value;
};

var missingNumber2 = function(nums) {
  const n = nums.length;
  let sum = (n+1) / 2 * n
  for (let num of nums) {
    sum -= num;
  }
  return sum;
};

console.log(missingNumber2([9,6,4,2,3,5,8,0,1]));