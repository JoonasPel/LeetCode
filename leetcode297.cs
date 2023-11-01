using System;
using System.Text;

/*
QUESTION: 297. Serialize and Deserialize Binary Tree

Serialization is the process of converting a data structure or object into
a sequence of bits so that it can be stored in a file or memory buffer,
or transmitted across a network connection link to be reconstructed later in
the same or another computer environment.

Design an algorithm to serialize and deserialize a binary tree. There is
no restriction on how your serialization/deserialization algorithm should work.
You just need to ensure that a binary tree can be serialized to a string and
this string can be deserialized to the original tree structure.

Clarification: The input/output format is the same as how LeetCode serializes
a binary tree. You do not necessarily need to follow this format, so please
be creative and come up with different approaches yourself.

APPROACH:
To serialize, travel the tree pre-order and add nodes to a list (later 
transformed to string) with a separator ','. null nodes are 'n'.
The result can be something like this: 1,2,n,n,3,4,n,n,5,n,n

To deserialize, travel the tree pre-order while going through the nodes list
(transformed from string) and create nodes at the same time. 
*/

public class Program
{

  public class TreeNode
  {
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public class Codec
  {

    // Encodes a tree to a single string.
    // null represented as 'n' only.
    public string serialize(TreeNode root)
    {
      if (root == null) return "n,";
      IList<string> nodes = new List<string>();

      void Visit(TreeNode? node)
      {
        if (node == null)
        {
          nodes.Add("n");
          return;
        }
        nodes.Add(node.val.ToString());
        Visit(node.left);
        Visit(node.right);
      }

      Visit(root);
      return string.Join(',', nodes);
    }

    // Decodes your encoded data to tree.
    public TreeNode? deserialize(string data)
    {
      if (data[0] == 'n') return null;

      IList<string> nodes = data.Split(',');
      TreeNode root = new TreeNode(int.Parse(nodes[0]), null, null);
      int nodeIndex = 0;

      void Visit(TreeNode? node)
      {
        if (nodes[++nodeIndex] == "n")
        {
          node.left = null;
        }
        else
        {
          TreeNode left = new TreeNode(int.Parse(nodes[nodeIndex]), null, null);
          node.left = left;
        }
        if (node.left != null) Visit(node.left);

        if (nodes[++nodeIndex] == "n")
        {
          node.right = null;
        }
        else
        {
          TreeNode right = new TreeNode(int.Parse(nodes[nodeIndex]), null, null);
          node.right = right;
        }
        if (node.right != null) Visit(node.right);
      }

      try
      {
        Visit(root);
      }
      catch (IndexOutOfRangeException) { }
      return root;
    }
  }


  public static void Main()
  {
    TreeNode node5 = new TreeNode(5);
    TreeNode node4 = new TreeNode(4);
    TreeNode node3 = new TreeNode(3, node4, node5);
    TreeNode node2 = new TreeNode(2);
    TreeNode root = new TreeNode(1, node2, node3);

    Codec ser = new Codec();
    Codec deser = new Codec();

    string serializedTree = ser.serialize(root);
    TreeNode newRoot = deser.deserialize(serializedTree);
    Console.WriteLine($"success? {serializedTree == ser.serialize(newRoot)}");
  }

}
