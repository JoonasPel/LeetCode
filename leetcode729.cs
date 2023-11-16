using System;
using System.Text;

/*
DIFFICULTY: Medium
QUESTION: 729. My Calendar I

You are implementing a program to use as your calendar. We can add a new event
if adding the event will not cause a double booking.

A double booking happens when two events have some non-empty intersection
(i.e., some moment is common to both events.).

The event can be represented as a pair of integers start and end that
represents a booking on the half-open interval [start, end), the range of real
numbers x such that start <= x < end.

Implement the MyCalendar class:

    MyCalendar() Initializes the calendar object.
    boolean book(int start, int end) Returns true if the event can be added to
    the calendar successfully without causing a double booking. Otherwise,
    return false and do not add the event to the calendar.

APPROACH:
Using SortedList<int,int> where key is start and value is end. First try to
insert the event into sortedlist, if the same start time exists, catch error.
If inserting is success, then get the index of the new event and check if the
event before it ends before or same time when new event starts. And also check
if the next event after new event starts after or same time when new event ends
If either of these neighbour events overlap, remember to remove new event!
*/

public class MyCalendar
{
  SortedList<int, int> intervals;

  public MyCalendar()
  {
    intervals = new SortedList<int, int>();
  }

  public bool Book(int start, int end)
  {
    try
    {
      intervals.Add(start, end);
    }
    catch (ArgumentException)
    {
      return false;
    }
    int index = intervals.IndexOfKey(start);
    if (index - 1 >= 0)
    {
      if (intervals.Values[index - 1] > start)
      {
        intervals.RemoveAt(index);
        return false;
      }
    }
    if (index + 1 < intervals.Count)
    {
      if (intervals.Keys[index + 1] < end)
      {
        intervals.RemoveAt(index);
        return false;
      }
    }
    return true;
  }

}

public class Solution
{
  public static void Main()
  {
    MyCalendar calendar = new MyCalendar();
    Console.WriteLine(calendar.Book(10, 20));
    Console.WriteLine(calendar.Book(15, 25));
    Console.WriteLine(calendar.Book(20, 30));
  }
}
