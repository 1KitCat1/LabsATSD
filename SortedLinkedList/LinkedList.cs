using System;
using System.Collections;
using System.Transactions;
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
        /// <summary>
        /// Insert element into the first position
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var node = new Node<T>(data);
            node.Next = Head;
            Head = node;
            Count++;
        }
        
        /// <summary>
        /// Delete first equal element from the Linked List
        /// </summary>
        /// <param name="data"></param>
        /// <returns>true if element has been deleted, false otherwise</returns>
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
        /// <summary>
        /// Print the elements of Linked List
        /// </summary>
        public void Print()
        {
            foreach (var item in this)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Insert element into the Linked List so that it stays sorted
        /// </summary>
        /// <param name="data"></param>
        public void InsertSorted(T data)
        {
            if (Head == null)
            {
                this.Add(data);
            }
            else
            {
                var node = new Node<T>(data);
                if (!Head.CompareNodes(node))
                {
                    this.AppendHead(data);
                    return;
                }
                
                var previous = Head;
                var current = Head.Next;
                while (current != null)
                {
                    if (node.CompareNodes(current))
                    {
                        previous.Next = node;
                        node.Next = current;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }

                this.Add(node.Data);
            }
        }
        /// <summary>
        /// Deletes all duplicates
        /// </summary>
        public void DeleteDuplicated()
        {
            var currentNode = Head.Next;
            T last = Head.Data;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(last)) Delete(last);
                last = currentNode.Data;
                currentNode = currentNode.Next;
            }
        }
        /// <summary>
        /// Reverse the Linked List
        /// </summary>
        public void Reverse()
        {
            if (Count >= 2)
            {
                var previous = Head;
                var current = Head.Next;
                previous.Next = null;
                Tail = Head;
                Tail.Next = null;
                
                while (current != null)
                {
                    var next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                Head = previous;
            } 
        }

        public int FindPosition(T data)
        {
            int counter = 0;
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(data)) return counter;
                currentNode = currentNode.Next;
            }

            return -1;
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