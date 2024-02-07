/*
DIFFICULTY: Easy
QUESTION: 2073. Time Needed to Buy Tickets

There are n people in a line queuing to buy tickets, where the 0th person is at
the front of the line and the (n - 1)th person is at the back of the line.

You are given a 0-indexed integer array tickets of length n where the number of
tickets that the ith person would like to buy is tickets[i].

Each person takes exactly 1 second to buy a ticket. A person can only buy 1
ticket at a time and has to go back to the end of the line
(which happens instantaneously) in order to buy more tickets. If a person does
not have any tickets left to buy, the person will leave the line.

Return the time taken for the person at position k (0-indexed) to finish buying
tickets.

APPROACH:
People in front of the person k are able to buy at most as many tickets as k
is before k is finished. People behind person k are able to buy at most one
less tickets before k is finished. So just sum all these numbers and also all
tickets that k itself buys.
*/

public class Solution
{
  public int TimeRequiredToBuy(int[] tickets, int k)
  {
    int time = 0;
    int threshold = tickets[k];
    for (int i = 0; i < tickets.Length; i++)
    {
      time += Math.Min(tickets[i], i > k ? threshold - 1 : threshold);
    }
    return time;
  }

  public static void Main()
  {
    Solution app = new Solution();
    app.TimeRequiredToBuy(new int[] { 5, 1, 1, 1 }, 0);
  }
}
