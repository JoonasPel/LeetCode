using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 648. Replace Words

In English, we have a concept called root, which can be followed by some other
word to form another longer word - let's call this word successor. For example,
when the root "an" is followed by the successor word "other", we can form a new
word "another".

Given a dictionary consisting of many roots and a sentence consisting of words
separated by spaces, replace all the successors in the sentence with the root
forming it. If a successor can be replaced by more than one root, replace it
with the root that has the shortest length.

Return the sentence after the replacement.

APPROACH:
Create a Set from the roots. Split the sentence to separate words array.
Then go through the words char by char and check from the Set if roots exist.
If a root is found, change that word into that root.
*/


public class Solution
{

  public string ReplaceWords(IList<string> dictionary, string sentence)
  {
    HashSet<string> roots = new HashSet<string>(dictionary);
    string[] words = sentence.Split(' ');
    int index = 0;
    foreach (string word in words)
    {
      for (int i = 0; i < word.Length; i++)
      {
        if (roots.Contains(word[0..(i + 1)]))
        {
          words[index] = word[0..(i + 1)];  // replace successor with root
          break;
        }
      }
      index++;
    }
    return string.Join(' ', words);
  }

  public static void Main()
  {
    Solution app = new Solution();
    Console.WriteLine(app.ReplaceWords(
      new List<string> { "cat", "bat", "rat" }, "the cattle was rattled by the battery"));
    Console.WriteLine(app.ReplaceWords(
new List<string> { "a", "b", "c" }, "aadsfasf absbs bbab cadsfafs"));
  }
}
