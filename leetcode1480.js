/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function(nums) {
  let earlierNumber = 0;
  for (let index=0; index<nums.length; index++) {
    earlierNumber = nums[index] = nums[index] + earlierNumber;
  }
  return nums;
};