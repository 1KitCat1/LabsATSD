using System.Collections;
using System.Xml.XPath;

namespace SortedLinkedList
{
    public class LinkedList<T> : IEnumerable
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        /// <summary>
        /// Default constructor of Linked List
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Create Linked List with first Element
        /// </summary>
        public LinkedList(T data)
        {
            var node = new Node<T>(data);
            Head = node;
            Tail = node;
            Count = 1;
        }
        /// <summary>
        /// Insert one element in Linked List
        /// </summary>
        /// <param name="data"></param>
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

        public void AppendHead(T data)
        {
            var node = new Node<T>(data);
            node.Next = Head;
            Head = node;
            Count++;
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

        public IEnumerator GetEnumerator()
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }
    }
}