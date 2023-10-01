/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function(nums) {
  let zeroes = 0;
  const totalProduct = nums.reduce((acc, curr) => {
    if (curr !== 0) acc *= curr;
    else zeroes++;
    return acc;
  }, 1);

  let resultArr = [];
  for (let val of nums) {
    let tempProduct = 0;
    if (val !== 0 && zeroes === 0) { 
      tempProduct = totalProduct * (Math.pow(val, -1)); 
    }
    else if (val === 0 && zeroes <= 1) tempProduct = totalProduct;
    resultArr.push(tempProduct);
  }
  return resultArr;
};

console.log(productExceptSelf([-1,1,0,-3,3]));
console.log(productExceptSelf([1,2,3,4]));