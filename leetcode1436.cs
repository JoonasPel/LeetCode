using System;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 1436. Destination City

You are given the array paths, where paths[i] = [cityAi, cityBi] means there
exists a direct path going from cityAi to cityBi. Return the destination city,
that is, the city without any path outgoing to another city.

It is guaranteed that the graph of paths forms a line without any loop,
therefore, there will be exactly one destination city.

APPROACH:
Save start cities (cityA) to a list and end cities (cityB) to another list.
The destination city is the city that is in end cities list but not in start
cities list.
*/


public class Solution
{

  public string DestCity(IList<IList<string>> paths)
  {
    HashSet<string> citiesA = new HashSet<string>();
    HashSet<string> citiesB = new HashSet<string>();
    foreach (var path in paths)
    {
      citiesA.Add(path[0]);
      citiesB.Add(path[1]);
    }
    citiesB.ExceptWith(citiesA);
    return citiesB.First();
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
