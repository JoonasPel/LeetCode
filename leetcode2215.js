/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[][]}
 */
var findDifference = function(nums1, nums2) {
  nums1 = Array.from(new Set(nums1));
  nums2 = Array.from(new Set(nums2));
  nums1.sort((a, b) => {return a - b});
  nums2.sort((a, b) => {return a - b});

  let num1CurrentIndex = 0;
  let num2CurrentIndex = 0;
  let num1, num2;
  while (true) {
    [num1, num2] = [nums1[num1CurrentIndex], nums2[num2CurrentIndex]];
    if (num1 === num2 && num1 !== undefined && num2 !== undefined) {
      nums1.splice(num1CurrentIndex, 1);
      nums2.splice(num2CurrentIndex, 1);
    } else {
      if (num1 === undefined || num2 === undefined) {return [nums1, nums2]; }
      if (num1 < num2) {
        num1CurrentIndex++;
      } else {
        num2CurrentIndex++;
      }
    }
  }
};

console.log(findDifference([80,5,-20,33,26,29], [-69,0,-36,52,-84,-34,-67,-100,80]));