/*
DIFFICULTY: Easy
QUESTION: 1854. Maximum Population Year

You are given a 2D integer array logs where each logs[i] = [birthi, deathi]
indicates the birth and death years of the ith person.

The population of some year x is the number of people alive during that year.
The ith person is counted in year x's population if x is in the inclusive range
[birthi, deathi - 1]. Note that the person is not counted in the year that they
die.

Return the earliest year with the maximum population.

INTUITION/APPROACH:
Make a dictionary where key is the year and value is the population. Go through
all the logs and increase every year population by one when a person of that
log has been alive then. At the end, find the smallest year with max population
*/

public class Solution
{
  public int MaximumPopulation(int[][] logs)
  {
    Dictionary<int, int> population = new Dictionary<int, int>();
    foreach (int[] log in logs)
    {
      for (int i = log[0]; i < log[1]; i++)
      {
        population.TryGetValue(i, out int pop);
        population[i] = pop + 1;
      }
    }
    int maxPopulation = 0;
    int earlierYear = 0;
    foreach (KeyValuePair<int, int> year in population)
    {
      if (year.Value > maxPopulation)
      {
        maxPopulation = year.Value;
        earlierYear = year.Key;
      }
      else if (year.Value == maxPopulation && year.Key < earlierYear)
      {
        earlierYear = year.Key;
      }
    }
    return earlierYear;
  }

  public static void Main()
  {
    Solution app = new Solution();
  }
}
