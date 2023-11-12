using System;
using System.Security.Cryptography;

/*
DIFFICULTY: Easy
QUESTION: 705. Design HashSet

Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

    void add(key) Inserts the value key into the HashSet.

    bool contains(key) Returns whether the value key exists in the
    HashSet or not.
    
    void remove(key) Removes the value key in the HashSet.
    If key does not exist in the HashSet, do nothing.


APPROACH:
*/

public class Program
{

  public class MyHashSet
  {
    private class ListNode
    {
      public int key;
      public ListNode next;
      public ListNode(int key, ListNode next = null)
      {
        this.key = key;
        this.next = next;
      }
    }

    MD5 md5 = MD5.Create();
    private int bucketSize = 100;
    ListNode?[] table;

    public MyHashSet()
    {
      table = new ListNode[bucketSize];
      int i = 0;
      while (i < bucketSize)
      {
        table[i] = null;
        i++;
      }
    }

    private int Hasher(int key)
    {
      var hashArr = md5.ComputeHash(BitConverter.GetBytes(key));
      int hashInt = BitConverter.ToInt32(hashArr, 0);
      return Math.Abs(hashInt) % bucketSize;
    }

    public void Add(int key)
    {
      int index = Hasher(key);
      if (table[index] == null)
      {
        table[index] = new ListNode(key);
      }
      else
      {
        ListNode current = table[index];
        while (true)
        {
          if (current.key == key)
          {
            return;
          }
          if (current.next == null) break;
          current = current.next;
        }
        current.next = new ListNode(key);
      }
    }

    public bool Contains(int key)
    {
      int index = Hasher(key);
      ListNode current = table[index];
      while (current != null)
      {
        if (current.key == key) return true;
        current = current.next;
      }
      return false;
    }

    public void Remove(int key)
    {
      int index = Hasher(key);
      ListNode current = table[index];
      ListNode prev = null;
      while (current != null)
      {
        if (current.key == key)
        {
          if (prev != null) prev.next = current.next;
          else
          {
            table[index] = current.next;
          }
        }
        prev = current;
        current = current.next;
      }
    }
  }

  public static void Main()
  {
    MyHashSet Set = new MyHashSet();
    Set.Add(500);
    Set.Add(600);
    Set.Add(700);
    Set.Add(800);
    Console.WriteLine(Set.Contains(500));
    Console.WriteLine(Set.Contains(600));
    Console.WriteLine(Set.Contains(700));
    Console.WriteLine(Set.Contains(800));
    Set.Remove(600);
    Set.Remove(700);
    Console.WriteLine(Set.Contains(500));
    Console.WriteLine(Set.Contains(600));
    Console.WriteLine(Set.Contains(700));
    Console.WriteLine(Set.Contains(800));
  }
}
