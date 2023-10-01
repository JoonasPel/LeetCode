/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {
  let searchLowerLimitIdx = 0;
  let searchUpperLimitIdx = nums.length - 1;
  while (searchUpperLimitIdx - searchLowerLimitIdx > 1) {
    let searchIndex = Math.floor((searchUpperLimitIdx + searchLowerLimitIdx) / 2);
    let number = nums[searchIndex];
    if (number === target) { return searchIndex; }
    else if (number > target) { searchUpperLimitIdx = searchIndex; }
    else { searchLowerLimitIdx = searchIndex; }
  }
  if (nums[searchLowerLimitIdx] === target) { return searchLowerLimitIdx; }
  if (nums[searchUpperLimitIdx] === target) { return searchUpperLimitIdx; }
  return -1;
};

console.log(search([-1,2], 2));