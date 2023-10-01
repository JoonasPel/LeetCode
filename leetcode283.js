/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function(nums) {
  let removedZeroesCount = index = 0;
  let length = nums.length;
  for (let i=0; i<length;i++) {
    if (nums[index] === 0) {
      nums.splice(index, 1);
      removedZeroesCount++;
    } else {
      index++;
    }
  }
  let zeroes = new Array(removedZeroesCount).fill(0);
  nums.push(...zeroes);
  return nums;
};

console.log(moveZeroes([0,1,0,3,12]));