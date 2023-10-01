/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersect = function(nums1, nums2) {
  let numbers1 = new Map();
  for (let num of nums1) {
    let temp = numbers1.get(num) ?? 0;
    numbers1.set(num, ++temp);
  }
  let intersectNums = new Array();
  for (let num of nums2) {
    let count = numbers1.get(num) ?? 0;
    if (count > 0) {
      numbers1.set(num, count - 1);
      intersectNums.push(num); 
    }   
  }
  return intersectNums;
};

console.log(intersect([4,9,5,4,8], [9,4,9,8,4]));