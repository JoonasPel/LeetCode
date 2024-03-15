/*
DIFFICULTY: Easy
QUESTION: 1773. Count Items Matching a Rule

You are given an array items, where each items[i] = [typei, colori, namei]
describes the type, color, and name of the ith item. You are also given a rule
represented by two strings, ruleKey and ruleValue.

The ith item is said to match the rule if one of the following is true:

    ruleKey == "type" and ruleValue == typei.
    ruleKey == "color" and ruleValue == colori.
    ruleKey == "name" and ruleValue == namei.

Return the number of items that match the given rule.

INTUITION/APPROACH:
Loop the items and check how many has the correct ruleValue.
The ruleKey is always in the same index so we can check it directly.
*/

public class Solution
{
  public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
  {
    int result = 0;
    int keyIndex;
    switch (ruleKey)
    {
      case "type":
        keyIndex = 0;
        break;
      case "color":
        keyIndex = 1;
        break;
      case "name":
        keyIndex = 2;
        break;
      default:
        throw new InvalidDataException("Invalid ruleKey");
    }
    foreach (IList<string> item in items)
    {
      if (item[keyIndex].Equals(ruleValue, StringComparison.Ordinal))
      {
        result++;
      }
    }
    return result;
  }

  public static void Main()
  {
  }
}
