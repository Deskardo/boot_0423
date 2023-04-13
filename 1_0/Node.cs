using System.Text;

public class Node
{
  public int Value;
  public Node Next;

  public Node(int value)
  {
    Value = value;
  }
}


public class NodeList
{
  public Node head;

  public void Create(int value)
  {
    if (head == null)
    {
      head = new Node(value);
    }
    else
    {
      Node current = head;
      while (current.Next != null) current = current.Next;
      current.Next = new Node(value);
    }
  }

  public string Print()
  {
    StringBuilder sb = new();
    Print(head, sb);
    return sb.ToString();
  }

  private void Print(Node node, StringBuilder sb)
  {
    if (node != null)
    {
      sb.Append(node.Value + " ");
      Print(node.Next, sb);
    }
  }

}

