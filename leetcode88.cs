class Program {
  // remove static and ref keyword if copy-pasted and run in leetcode!
  static public void Merge(ref int[] nums1, int m, int[] nums2, int n) {
    int nums1Idx = m-1;
    int nums2Idx = n-1;
    int resIdx = nums1.Length-1;
    int currNum2;
    while (nums2Idx >= 0) {
      currNum2 = nums2[nums2Idx];
      if (nums1Idx < 0 || currNum2 >= nums1[nums1Idx]) {
        nums1[resIdx] = currNum2;
        nums2Idx--;
      } else {
        nums1[resIdx] = nums1[nums1Idx];
        nums1Idx--;
      }
      resIdx--;
    }
  }

  static public void Main() {
    int[] nums1 = {1,2,3,0,0,0};
    int m = 3;
    int[] nums2 = {2,5,6};
    int n = 3;

    Merge(ref nums1, m, nums2, n);
    foreach (int num in nums1) {
      Console.Write($"{num} ");
    }
  }
}
