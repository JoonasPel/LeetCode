/*
DIFFICULTY: Medium
QUESTION: 841. Keys and Rooms

There are n rooms labeled from 0 to n - 1 and all the rooms are locked except
for room 0. Your goal is to visit all the rooms. However, you cannot enter a
locked room without having its key.

When you visit a room, you may find a set of distinct keys in it. Each key has
a number on it, denoting which room it unlocks, and you can take all of them
with you to unlock the other rooms.

Given an array rooms where rooms[i] is the set of keys that you can obtain if
you visited room i, return true if you can visit all the rooms, or false
otherwise.

INTUITION/APPROACH:
Recursively go through rooms and check if we can visit all. Also we do not need
different paths so just visit every room only once. Meaning if same room is
found again, return. After discovering all rooms are visited, stop recursion
with custom exception.
*/

public class Solution
{
  public class RecursionKillException : Exception
  {
    public RecursionKillException() { }
    public RecursionKillException(string message) : base(message) { }
  }

  public bool CanVisitAllRooms(IList<IList<int>> rooms)
  {
    int totalRooms = rooms.Count;
    HashSet<int> visited = new();
    void Visit(int roomNumber)
    {
      if (visited.Count == totalRooms)
      {
        throw new RecursionKillException("Kill recursion");
      }
      foreach (int key in rooms[roomNumber])
      {
        if (visited.Add(key))
        {
          Visit(key);
        }
      }
    }
    try
    {
      visited.Add(0);
      Visit(0);
      return false;
    }
    catch (RecursionKillException)
    {
      return true;
    }
  }

  public static void Main()
  {
    Solution app = new Solution();
    bool res = app.CanVisitAllRooms([[1], [2], [3], []]);
    Console.WriteLine(res);
  }
}
