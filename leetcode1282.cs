using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 1282. Group the People Given the Group Size They Belong To

There are n people that are split into some unknown number of groups. Each
person is labeled with a unique ID from 0 to n - 1.

You are given an integer array groupSizes, where groupSizes[i] is the size of
the group that person i is in. For example, if groupSizes[1] = 3, then
person 1 must be in a group of size 3.

Return a list of groups such that each person i is in a group of size
groupSizes[i].

Each person should appear in exactly one group, and every person must be in
a group. If there are multiple answers, return any of them. It is guaranteed
that there will be at least one valid solution for the given input.

APPROACH:
I made two different implementations. Basic idea is to have groups in a 
dictionary where key is the groupsize and groups are in value. Then keep going
through people and add them to the correct group. 
*/


public class Solution
{
  public IList<IList<int>> GroupThePeople2(int[] groupSizes)
  {
    IList<IList<int>> groups = new List<IList<int>>();
    var toBeFilledGroups = new Dictionary<int, IList<IList<int>>>();
    int personID = 0;
    foreach (int groupSize in groupSizes)
    {
      if (toBeFilledGroups.TryGetValue(groupSize, out var value))
      {
        var lastList = value.Last();
        if (lastList.Count == groupSize)
        {
          IList<int> newList = new List<int>() { personID };
          value.Add(newList);
        }
        else
        {
          lastList.Add(personID);
        }
      }
      else
      {
        IList<IList<int>> groupList = new List<IList<int>>();
        groupList.Add(new List<int> { personID });
        toBeFilledGroups.Add(groupSize, groupList);
      }
      personID++;
    }

    foreach (var groupList in toBeFilledGroups)
    {
      foreach (var group in groupList.Value)
      {
        groups.Add(group);
      }
    }
    return groups;
  }

  public IList<IList<int>> GroupThePeople(int[] groupSizes)
  {
    IList<IList<int>> groups = new List<IList<int>>();
    var toBeFilledGroups = new Dictionary<int, IList<int>>();
    int personID = 0;
    foreach (int groupSize in groupSizes)
    {
      if (toBeFilledGroups.TryGetValue(groupSize, out IList<int> value))
      {
        value.Add(personID);
      }
      else
      {
        var newList = new List<int>() { personID };
        toBeFilledGroups.Add(groupSize, newList);
      }
      personID++;
    }
    foreach (var filledGroup in toBeFilledGroups)
    {
      IEnumerable<int[]> chunks = filledGroup.Value.Chunk(filledGroup.Key);
      foreach (var chunk in chunks)
      {
        groups.Add(chunk.ToArray());
      }
    }
    return groups;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
