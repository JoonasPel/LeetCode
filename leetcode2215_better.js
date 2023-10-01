/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[][]}
 */
var findDifference = function(nums1, nums2) {
  nums1 = Array.from(new Set(nums1));
  nums2 = new Set(nums2);

  const nums1length = nums1.length;
  let tempNum1;
  let nums1Result = new Set();
  for (index=0; index<nums1length; index++) {
    tempNum1 = nums1[index];
    if (nums2.has(tempNum1)) {
      nums2.delete(tempNum1);
    } else {
      nums1Result.add(tempNum1);
    }
  }
  return [Array.from(nums1Result), Array.from(nums2)];
};

console.log(findDifference([1,2,3,4,4], [1,1,3,2,5,4]));