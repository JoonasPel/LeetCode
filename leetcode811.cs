using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 811. Subdomain Visit Count

A website domain "discuss.leetcode.com" consists of various subdomains. At the
top level, we have "com", at the next level, we have "leetcode.com" and at the
lowest level, "discuss.leetcode.com". When we visit a domain like
"discuss.leetcode.com", we will also visit the parent domains "leetcode.com"
and "com" implicitly.

A count-paired domain is a domain that has one of the two formats
"rep d1.d2.d3" or "rep d1.d2" where rep is the number of visits to the domain
and d1.d2.d3 is the domain itself.

    For example, "9001 discuss.leetcode.com" is a count-paired domain that
    indicates that discuss.leetcode.com was visited 9001 times.

Given an array of count-paired domains cpdomains, return an array of the
count-paired domains of each subdomain in the input. You may return the answer
in any order.

APPROACH:
Parse different subdomains and save them to a dictionary with the visit count
as a value. Increment that count everytime the same domain is seen again.
Then turn those items into a list for returning.
*/


public class Solution
{

  public IList<string> SubdomainVisits(string[] cpdomains)
  {
    Dictionary<string, int> visits = new Dictionary<string, int>();
    int tempCount;
    string tempDomain;
    string[] splitResult;
    IList<string> allDomains = new List<string>();
    foreach (string cpdomain in cpdomains)
    {
      allDomains.Clear();
      splitResult = cpdomain.Split(' ');
      tempCount = Int32.Parse(splitResult[0]);
      tempDomain = splitResult[1];
      string[] subDomains = tempDomain.Split('.');
      if (subDomains.Length == 2)
      {
        allDomains.Add(subDomains[1]);
        allDomains.Add(splitResult[1]);
      }
      else
      {
        allDomains.Add(subDomains[2]);
        allDomains.Add(subDomains[1] + '.' + subDomains[2]);
        allDomains.Add(splitResult[1]);
      }
      foreach (string domain in allDomains)
      {
        if (visits.TryGetValue(domain, out int count))
        {
          visits[domain] = count + tempCount;
        }
        else
        {
          visits.Add(domain, tempCount);
        }
      }
    }
    IList<string> result = new List<string>();
    foreach (var item in visits)
    {
      result.Add(item.Value + " " + item.Key);
    }
    return result;
  }

  public static void Main()
  {
    Solution app = new Solution();
    string[] domains = new string[4]
    {
      "900 google.mail.com",
      "50 yahoo.com",
      "1 intel.mail.com",
      "5 wiki.org",
    };
    IList<string> results = app.SubdomainVisits(domains);
    foreach (var result in results) Console.WriteLine(result);
  }
}
