using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 763. Partition Labels

You are given a string s. We want to partition the string into as many parts
as possible so that each letter appears in at most one part.

Note that the partition is done so that after concatenating all the parts in
order, the resultant string should be s.

Return a list of integers representing the size of these parts.

APPROACH:
Pretty bad but works. Goes through the string and finds the first seen and last
seen index of every char. Then creates the partitions by checking what chars
needs to be in the same partition according to first/last seen indexes.
Finally calculates the partition sizes.
*/


public class Solution
{
  public IList<int> PartitionLabels(string s)
  {
    var firstAndLastSeen = new Dictionary<char, KeyValuePair<int, int>>();
    char tempChar;
    for (int index = 0; index < s.Length; index++)
    {
      tempChar = s[index];
      if (firstAndLastSeen.TryGetValue(tempChar, out var value))
      {
        firstAndLastSeen[tempChar] = new KeyValuePair<int, int>(value.Key, index);
      }
      else
      {
        firstAndLastSeen[tempChar] = new KeyValuePair<int, int>(index, index);
      }
    }

    var partitions = new List<(int, int)>();
    int firstSeenIndex, lastSeenIndex;
    foreach (var item in firstAndLastSeen)
    {
      firstSeenIndex = item.Value.Key;
      lastSeenIndex = item.Value.Value;
      if (partitions.Count == 0)
      {
        partitions.Add((firstSeenIndex, lastSeenIndex));
      }
      else
      {
        var lastPartition = partitions[^1];
        if (firstSeenIndex > lastPartition.Item2)
        {
          partitions.Add((firstSeenIndex, lastSeenIndex));
        }
        else if (lastSeenIndex > lastPartition.Item2)
        {
          partitions[^1] = (partitions[^1].Item1, lastSeenIndex);
        }
      }
    }

    IList<int> result = new List<int>();
    foreach (var partition in partitions)
    {
      result.Add(partition.Item2 - partition.Item1 + 1);
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.PartitionLabels("ababcbacadefegdehijhklij");
  }
}
