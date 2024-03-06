/*
DIFFICULTY: Easy
QUESTION: 1791. Find Center of Star Graph

There is an undirected star graph consisting of n nodes labeled from 1 to n.
A star graph is a graph where there is one center node and exactly n - 1 edges
that connect the center node with every other node.

You are given a 2D integer array edges where each edges[i] = [ui, vi] indicates
that there is an edge between the nodes ui and vi. Return the center of the
given star graph.

INTUITION/APPROACH:
We can just check two different edges to find out the middle one
*/

public class Solution
{
  public int FindCenter(int[][] edges)
  {
    return edges[0].Intersect(edges[1]).Single();
  }

  public static void Main()
  {
  }
}
