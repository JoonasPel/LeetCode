/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums) {
  let goalFound = false;
  const goalIndex = nums.length - 1;
  let visited = new Set();

  const visit = (index) => {
    if (index === goalIndex) { goalFound = true; }
    if (goalFound) { return; }

    const jumpPower = nums[index];
    if (index + jumpPower >= goalIndex) {
      goalFound = true;
      return; 
    }
    for (let i=index+jumpPower; i>index; i--) {
      if (!goalFound && !visited.has(i)) {
        visit(i);
        visited.add(index);
      }
      if (goalFound) { break; }
    }
  };

  visit(0);
  return goalFound;
};

console.log(canJump([3,3,1,0,1,1,1,1,4]));