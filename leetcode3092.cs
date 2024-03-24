/*
DIFFICULTY: Medium
QUESTION: 3092. Most Frequent IDs

DESCRIPTION:
The problem involves tracking the frequency of IDs in a collection that changes
over time. You have two integer arrays, nums and freq, of equal length n. Each
element in nums represents an ID, and the corresponding element in freq
indicates how many times that ID should be added to or removed from the
collection at each step.

    Addition of IDs: If freq[i] is positive, it means freq[i] IDs with the
    value nums[i] are added to the collection at step i.
    Removal of IDs: If freq[i] is negative, it means -freq[i] IDs with the
    value nums[i] are removed from the collection at step i.

Return an array ans of length n, where ans[i] represents the count of the most
frequent ID in the collection after the ith step. If the collection is empty at
any step, ans[i] should be 0 for that step.

INTUITION/APPROACH:
I made this during contest but unfortunately didnt realise to use longs and
only 621/622 test cases passed.

The approach uses a dictionary to keep count of numbers and their current freqs
and also a priority queue to get the largest freq.
The idea is that every after every step the current element + freq is inserted
to the priority queue and always when an element is taken from the priority queue,
it is compared to the correct element+freq in dictionary to see if it is correct.
If not correct, we dequeue new elements from the priority queue until we find
something that is correct.

In other words: Dictionary always has correct freqs, prio queue has ability
to give the element with largest freq with O(log n) but it might be incorrect,
so with dictionary we can get the largest CORRECT freq from the prio queue.
*/

public class Solution
{
  public long[] MostFrequentIDs(int[] nums, int[] freq)
  {
    Dictionary<long, long> freqs = new();
    PriorityQueue<long, long> prios = new();
    long[] result = new long[nums.Length];
    for (int i = 0; i < freq.Length; i++)
    {
      int number = nums[i];
      int frequency = freq[i];

      freqs.TryGetValue(number, out long count);
      long newFreq = count + frequency;
      freqs[number] = newFreq;

      prios.Enqueue(number, -newFreq);

      while (prios.Count > 0)
      {
        prios.TryPeek(out long element, out long priority);
        if (-priority == freqs[element])
        {
          result[i] = -priority;
          break;
        }
        else
        {
          prios.Dequeue();
        }
      }
    }
    return result;
  }
}
