using System;
using System.Numerics;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 2363. Merge Similar Items

You are given two 2D integer arrays, items1 and items2, representing two sets
of items. Each array items has the following properties:

    items[i] = [valuei, weighti] where valuei represents the value and weighti
    represents the weight of the ith item.
    The value of each item in items is unique.

Return a 2D integer array ret where ret[i] = [valuei, weighti], with weighti
being the sum of weights of all items with value valuei.

Note: ret should be returned in ascending order by value.

Constraints:

    1 <= items1.length, items2.length <= 1000
    items1[i].length == items2[i].length == 2
    1 <= valuei, weighti <= 1000
    Each valuei in items1 is unique.
    Each valuei in items2 is unique.

APPROACH:
The Constraints say that the values in the arrs are max 1000, so we can create
a array of length 1001 and use it so that the value = index and
arr[index] = weight. Sum the weights to the correct index/value and then
create the result List from non-zero values in the array.
*/

public class Solution
{
  public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
  {
    int[] res = new int[1001];
    foreach (int[] item in items1)
    {
      res[item[0]] = item[1];
    }
    foreach (int[] item in items2)
    {
      res[item[0]] += item[1];
    }
    IList<IList<int>> result = new List<IList<int>>();
    for (int i = 0; i < res.Length; i++)
    {
      if (res[i] == 0) continue;
      result.Add(new List<int> { i, res[i] });
    }
    return result;
  }
}
