/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function(nums, k) {
  let len = nums.length;
  let temp = nums.splice(len - k % len);
  nums.unshift(...temp);
};

console.log(rotate([1,2,3,4,5,6,7], 3))