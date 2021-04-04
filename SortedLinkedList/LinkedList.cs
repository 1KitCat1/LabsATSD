namespace SortedLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        //constructors
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
        //
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (Tail != null)
            {
                Tail.Next = node;
                Tail = node;
                Count++;
            }
            else
            {
                Head = node;
                Tail = node;
                Count = 1;
            }
            
        }
    }
}