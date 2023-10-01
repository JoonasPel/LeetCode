class Program {
    // remove static keyword if copy-pasted and run in leetcode!
    static public int SearchInsert(int[] nums, int target) {
      int leftIdx = 0;
      int rightIdx = nums.Length - 1;
      int middleIdx = -1;
      int value, newMiddleIdx;
      while (true) {
        newMiddleIdx = (rightIdx+leftIdx)/2;
        // find the correct return index if binary search "converged"
        if (middleIdx == newMiddleIdx) {
          if (nums[leftIdx] == target) { return leftIdx; }
          if (nums[rightIdx] == target) { return rightIdx; }
          if (nums[rightIdx] < target) { return rightIdx + 1; }
          if (nums[leftIdx] > target) {
            return leftIdx - 1 == -1 ? 0 : leftIdx - 1;
          }
          return rightIdx;
        }
        middleIdx = newMiddleIdx;
        // normal binary search value check + edge movements
        value = nums[middleIdx];
        if (value == target) { return middleIdx; }
        if (value < target) {
          leftIdx = middleIdx;
        } else {
          rightIdx = middleIdx;
        }
      }
    }

    static public void Main() {
      AutoTest();
      int[] nums = {1,3,5,6};
      Console.WriteLine(SearchInsert(nums, 2));
    }

    static public void AutoTest() {
      int[] nums = {1,3,5,6,7,8,9,10};
      for (int i=0; i<nums.Length; i++) {
        Console.WriteLine(
          SearchInsert(nums, target: nums[i]) == i ? "PASS":"FAIL");
      }
    }
}
