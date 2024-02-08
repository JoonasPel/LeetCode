/*
DIFFICULTY: Easy
QUESTION: 2309. Greatest English Letter in Upper and Lower Case

Given a string of English letters s, return the greatest English letter which
occurs as both a lowercase and uppercase letter in s. The returned letter
should be in uppercase. If no such letter exists, return an empty string.

An English letter b is greater than another letter a if b appears after a in
the English alphabet.

INTUITION/APPROACH:
Save boolean to two arrays if a specific char exists as lower or uppercase.
Char ascii code is used as index, uppercase chars are made lowercase to have
same ascii code = index. Then we can find the greatest char that exists as both
lower and uppercase, OR stop early if 'Z' and 'z' are found, they always "win".
*/

public class Solution
{
  public string GreatestLetter(string s)
  {
    bool[] lowercaseExists = new bool[123]; // in ascii a=97, z=122
    bool[] uppercaseExists = new bool[123];
    foreach (char c in s)
    {
      if (char.IsUpper(c))
      {
        uppercaseExists[char.ToLower(c)] = true;
      }
      else
      {
        lowercaseExists[c] = true;
      }
      // Z+z is always an end condition if found
      if (lowercaseExists[122] && uppercaseExists[122])
      {
        return "Z";
      }
    }
    for (int i = 122; i >= 97; i--)
    {
      if (lowercaseExists[i] && uppercaseExists[i])
      {
        return ((char)i).ToString().ToUpper();
      }
    }
    return "";
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.GreatestLetter("lEeTcOdE"));
  }
}
