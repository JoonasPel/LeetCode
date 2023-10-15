public class Program
{
  public static int RemoveElement(int[] nums, int val)
  {
    int
    leftIdx = 0
    , swapsCount = 0
    , rightIdx = nums.Length-1;
    // not O^2
    while (leftIdx != rightIdx)
    {
      if (nums[leftIdx] == val)
      {
        while (leftIdx != rightIdx)
        {
          if (nums[rightIdx] != val)
          {
            (nums[leftIdx], nums[rightIdx]) = (nums[rightIdx], -1);
            rightIdx--;
            swapsCount++;
            break;
          } else {
            nums[rightIdx] = -1;
          }
          rightIdx--;
        }
      }
      leftIdx++;
    }
    return swapsCount;
  }

  public static void Main()
  {
    int[] nums = new int[] {0,1,2,2,3,0,4,2};
    RemoveElement(nums, val: 2);
  }
}