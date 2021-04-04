using System;

namespace SortedLinkedList
{
    /// <summary>
    /// Element of Linked List
    /// </summary>
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
        /// <summary>
        /// Compare data value of nodes
        /// </summary>
        /// <param name="other"></param>
        /// <returns>True if this is less then other</returns>
        public bool CompareNodes(Node<T> other)
        {
            if (Convert.ToInt32(this._data) < Convert.ToInt32(other._data)) return true;
            return false;
        }
    }
}