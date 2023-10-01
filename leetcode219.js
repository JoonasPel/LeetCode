/**
 * @param {number[]} nums
 * @param {number} k
 * @return {boolean}
 */
var containsNearbyDuplicate = function(nums, k) {
  let earlier = new Map();
  for (let i=0; i<nums.length; i++) {
    const val = nums[i];
    const inKrange = new Set(earlier.values());
    if (inKrange.has(val)) { return true; }
    
    earlier.set(i, val);
    if (i - k >= 0) {
      earlier.delete(i-k);
    }
  }
  return false;
};

console.log(containsNearbyDuplicate([1,2,3,1,2,3], 2));