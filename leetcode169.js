/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
  // ceil because if nums.length is even, we can confirm the result 
  // at nums.length / 2. no need for nums.length / 2 + 1.
  const majorityGoal = Math.ceil(nums.length / 2);
  let numAppearCounts = new Map();
  let tempKey, tempValue;
  for (let i=0; i<nums.length; i++) {
    tempKey = nums[i];
    tempValue = numAppearCounts.get(tempKey) ?? 0;
    if (++tempValue === majorityGoal) { return tempKey; }
    numAppearCounts.set(tempKey, tempValue);
  }
};

console.log(majorityElement([3,2,3]));