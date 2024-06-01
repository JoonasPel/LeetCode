/*
DIFFICULTY: Medium
QUESTION: 1817. Finding the Users Active Minutes

You are given the logs for users' actions on LeetCode, and an integer k. The
logs are represented by a 2D integer array logs where each
logs[i] = [IDi, timei] indicates that the user with IDi performed an action at
the minute timei.

Multiple users can perform actions simultaneously, and a single user can
perform multiple actions in the same minute.

The user active minutes (UAM) for a given user is defined as the number of
unique minutes in which the user performed an action on LeetCode. A minute can
only be counted once, even if multiple actions occur during it.

You are to calculate a 1-indexed array answer of size k such that,
for each j (1 <= j <= k), answer[j] is the number of users whose UAM equals j.

Return the array answer as described above.

INTUITION/APPROACH:
Save userId to dictionary as keys and their unique actions as a hashset.
The answer array will just have the hashset counts 1-indexed.
*/

public class Solution
{
  public int[] FindingUsersActiveMinutes(int[][] logs, int k)
  {
    Dictionary<int, HashSet<int>> userActions = new();
    foreach (int[] log in logs)
    {
      if (userActions.TryGetValue(log[0], out HashSet<int>? actions))
      {
        actions.Add(log[1]);
      }
      else
      {
        userActions.Add(log[0], new HashSet<int>() { log[1] });
      }
    }
    int[] answer = new int[k];
    foreach (var user in userActions)
    {
      answer[user.Value.Count - 1]++;
    }
    return answer;
  }

  public static void Main()
  {
    Solution app = new();
    app.FindingUsersActiveMinutes([[0, 5], [1, 2], [0, 2], [0, 5], [1, 3]], 5);
  }
}
