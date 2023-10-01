/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
  let [leftPtrIdx, rightPtrIdx] = [0, height.length - 1];
  let maxWaterSoFar = 0;

  while (leftPtrIdx !== rightPtrIdx) {
    const [heightLeft, heightRight] = [height[leftPtrIdx], height[rightPtrIdx]];
    const waterAmount = (rightPtrIdx-leftPtrIdx) * Math.min(
      heightLeft, heightRight);
    maxWaterSoFar = Math.max(maxWaterSoFar, waterAmount);

    if (heightLeft < heightRight) {
      leftPtrIdx++;
    } else {
      rightPtrIdx--;
    }
  }
  return maxWaterSoFar;
};

console.log(maxArea([1,8,6,2,5,4,8,3,7]));