namespace SortedLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        //constructor
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            var node = new Node<T>(data);
            Head = node;
            Tail = node;
            Count = 1;
        }
    }
}