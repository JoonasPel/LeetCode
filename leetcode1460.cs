/*
DIFFICULTY: Easy
QUESTION: 1460. Make Two Arrays Equal by Reversing Subarrays

You are given two integer arrays of equal length target and arr. In one step,
you can select any non-empty subarray of arr and reverse it. You are allowed to
make any number of steps.

Return true if you can make arr equal to target or false otherwise.

INTUITION/APPROACH:
Using dictionary, check that both arrays have exactly same items. If they do,
they can be made same doing the subarray reversing(somehow) but no need to know
how.
Also one could sort both arrays and check they are equal, but that would be
O(n*logn) and this dictionary solution is O(n).
*/

public class Solution
{
  public bool CanBeEqual(int[] target, int[] arr)
  {
    if (target.Length != arr.Length)
    {
      return false;
    }
    Dictionary<int, int> occurences = new();
    for (int i = 0; i < target.Length; i++)
    {
      occurences.TryGetValue(target[i], out int count);
      occurences[target[i]] = count + 1;
    }
    for (int i = 0; i < arr.Length; i++)
    {
      occurences.TryGetValue(arr[i], out int count);
      if (count == 0)
      {
        return false;
      }
      occurences[arr[i]] = count - 1;
    }
    return true;
  }

  public static void Main()
  {
  }
}
