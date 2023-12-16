using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 2079. Watering Plants

You want to water n plants in your garden with a watering can. The plants are
arranged in a row and are labeled from 0 to n - 1 from left to right where the
ith plant is located at x = i. There is a river at x = -1 that you can refill
your watering can at.

Each plant needs a specific amount of water. You will water the plants in the
following way:

    Water the plants in order from left to right.
    After watering the current plant, if you do not have enough water to
    completely water the next plant, return to the river to fully refill the
    watering can.
    You cannot refill the watering can early.

You are initially at the river (i.e., x = -1). It takes one step to move one
unit on the x-axis.

Given a 0-indexed integer array plants of n integers, where plants[i] is the
amount of water the ith plant needs, and an integer capacity representing the
watering can capacity, return the number of steps needed to water all the
plants.

APPROACH:
While calculating the steps taken, loop through all plants like this:
1. If we have enough water for the next plant, take 1 step and water it.
1.5 If we dont have enough water, go get refill and come back to the same index.
This always takes current index * 2 steps. Then take 1 step and water next plant
2. Repeat
*/


public class Solution
{

  public int WateringPlants(int[] plants, int capacity)
  {
    int totalSteps = 0;
    int currentWater = capacity;
    void waterPlant(int waterNeeded)
    {
      totalSteps++;
      currentWater -= waterNeeded;
    }
    int nextPlantWaterNeed;
    for (int i = 0; i < plants.Length; i++)
    {
      nextPlantWaterNeed = plants[i];
      if (nextPlantWaterNeed <= currentWater)
      {
        waterPlant(nextPlantWaterNeed);
      }
      else
      {
        totalSteps += 2 * i; // get refill and come back
        currentWater = capacity;
        waterPlant(nextPlantWaterNeed);
      }
    }
    return totalSteps;
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.WateringPlants(new int[] { 3, 2, 4, 2, 1 }, 6));
  }
}
