/*
DIFFICULTY: Medium
QUESTION: 797. All Paths From Source to Target

Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1,
find all possible paths from node 0 to node n - 1 and return them in any order.

The graph is given as follows: graph[i] is a list of all nodes you can visit
from node i (i.e., there is a directed edge from node i to node graph[i][j]).

INTUITION/APPROACH:
Recursively go through all paths and give the current path as param to the
next recursive calls. If target found, add that path to all paths. And no need
to continue further from target.
*/

public class Solution
{
  public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
  {
    int start = 0;
    int target = graph.Length - 1;
    IList<IList<int>> paths = new List<IList<int>>();

    void Visit(int nodeVal, int[] nodeNexts, IList<int> path)
    {
      path.Add(nodeVal);
      if (nodeVal == target)
      {
        paths.Add(path);
      }
      else
      {
        foreach (int next in nodeNexts)
        {
          Visit(next, graph[next], new List<int>(path));
        }
      }
    }

    Visit(start, graph[start], new List<int>());
    return paths;
  }

  public static void Main()
  {
  }
}
