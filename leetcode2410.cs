using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2410. Maximum Matching of Players With Trainers

You are given a 0-indexed integer array players, where players[i] represents
the ability of the ith player. You are also given a 0-indexed integer array
trainers, where trainers[j] represents the training capacity of the jth trainer

The ith player can match with the jth trainer if the player's ability is less
than or equal to the trainer's training capacity. Additionally, the ith player
can be matched with at most one trainer, and the jth trainer can be matched
with at most one player.

Return the maximum number of matchings between players and trainers that
satisfy these conditions.

APPROACH:
Sort player and trainers ascending. With two "pointers", one in players arr and
one in trainers arr, go through players arr and find the first possible trainer
for that player. If a trainer is not high number enough, go through trainers
until high enough is found. Stop when players or trainers arr's end is reached.
Both arrays are looped only once so this is O(n) and sorting is O(n*logn)
*/

public class Program
{

  public static int MatchPlayersAndTrainers(int[] players, int[] trainers)
  {
    Array.Sort(players);
    Array.Sort(trainers);
    int matchesFound = 0
    , trainerIndex = 0
    , playerIndex = 0;
    while (trainerIndex < trainers.Length && playerIndex < players.Length)
    {
      if (players[playerIndex] <= trainers[trainerIndex])
      {
        matchesFound++;
        playerIndex++;
      }
      trainerIndex++;
    }
    return matchesFound;
  }

  public static void Main()
  {
  }
}
