using System;

namespace SortedLinkedList
{
    /// <summary>
    /// Element of Linked List
    /// </summary>
    public class Node<T> 
    {
        public T Data { get; set; }
        
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
            if (Convert.ToInt32(this.Data) < Convert.ToInt32(other.Data)) return true;
            return false;
        }
    }
}