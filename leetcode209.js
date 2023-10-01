/**
 * @param {number} target
 * @param {number[]} nums
 * @return {number}
 */
var minSubArrayLen = function(target, nums) {
  nums.sort((a,b)=>b-a);

  let [result, sum, targetReached] = [0, 0, false];
  for (let numb of nums) {
    sum += numb;
    result++;
    if (sum >= target) {
      targetReached=true
      break;
    }
  }
  return targetReached ? result : 0;
};

console.log(minSubArrayLen(target = 12, nums = [2,3,1,2,4,3]));