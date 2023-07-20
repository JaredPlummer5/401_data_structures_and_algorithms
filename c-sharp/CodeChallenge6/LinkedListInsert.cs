namespace CodeChallenges
{
  public class InsertableLinkedList : LinkedList
  {

    //adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);
      CurrentNode = Head.Next;
      while (CurrentNode.Next != null)
      {
        CurrentNode = CurrentNode.Next;
      }
      CurrentNode.Next = newNode;
      newNode.Last = CurrentNode;
      Tail = newNode;

    }
    //adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(value);
      newNode.Next = Head;
      Head.Last = newNode;
      Head = newNode;

    }
    //adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
        Tail = Head;
      }
      else //insert after Head node
      {
        newNode.Next = Head.Next;
        Head.Next = newNode;
        newNode.Last = Head; // doubly linked update
        Tail = newNode;
      }
    }
  }
}