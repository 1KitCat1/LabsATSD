using System;

namespace SortedLinkedList
{
    public class Node<T>
    {
        private T _data;
        public T Data
        {
            get { return _data;}
            set
            {
                if (value != null) _data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }
        public Node<T> Next { get; set; }
        //constructor
        public Node(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}