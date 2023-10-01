var unnamed = function(nums) {
  const length = nums.length;
  let currentIndex = 1;
  let earlierUniqueNumber = nums[0];
  for (let i = 1; i < length; i++) {
    if (nums[i] !== earlierUniqueNumber) {
      nums[currentIndex] = nums[i];
      earlierUniqueNumber = nums[i];
      currentIndex++;
    }
  }
  nums.splice(currentIndex);
};

console.log(unnamed([0,0,1,1,1,2,2,3,3,4,6,6,6,6,6,7,8,8,9,9,10,10]));