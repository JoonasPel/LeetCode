using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

/*
DIFFICULTY: Easy
QUESTION: 706. Design HashMap

Design a HashMap without using any built-in hash table libraries.

Implement the MyHashMap class:

    MyHashMap() initializes the object with an empty map.
    void put(int key, int value) inserts a (key, value) pair into
    the HashMap. If the key already exists in the map, update the
    corresponding value.
    int get(int key) returns the value to which the specified key
    is mapped, or -1 if this map contains no mapping for the key.
    void remove(key) removes the key and its corresponding value
    if the map contains the mapping for the key.

APPROACH:
*/

public class Program
{

  public class MyHashMap
  {
    private class ListNode
    {
      public int key;
      public int val;
      public ListNode next;
      public ListNode(int key, int val, ListNode next = null)
      {
        this.key = key;
        this.val = val;
        this.next = next;
      }
    }

    MD5 md5 = MD5.Create();
    private int bucketSize = 100;
    ListNode?[] table;

    public MyHashMap()
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

    public void Put(int key, int value)
    {
      int index = Hasher(key);
      if (table[index] == null)
      {
        table[index] = new ListNode(key, value);
      }
      else
      {
        ListNode current = table[index];
        while (true)
        {
          if (current.key == key)
          {
            current.val = value;
            return;
          }
          if (current.next == null) break;
          current = current.next;
        }
        current.next = new ListNode(key, value);
      }
    }

    public int Get(int key)
    {
      int index = Hasher(key);
      ListNode current = table[index];
      while (current != null)
      {
        if (current.key == key) return current.val;
        current = current.next;
      }
      return -1;
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
  }
}
