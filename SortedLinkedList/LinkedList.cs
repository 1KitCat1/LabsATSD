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

        public bool Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }

                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        if (current == Tail)
                        {
                            previous.Next = null;
                            Tail = previous;
                        }
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            
            return false;
        }
    }
}