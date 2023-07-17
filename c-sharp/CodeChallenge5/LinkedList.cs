namespace CodeChallenges 
{
    public class LinkedList
    {
        public Node Head;


    //public LinkedList()
    //{
    //  Head = null;
    //}

    public void AddNewNode(Node node)
        {
            node.Next = Head;
            Head = node;
        }
    }

    public class Node
    {
        public Node? Next;
        public int Value;
        public Node(int value)
        {
            Value = value;
        }
    }
}