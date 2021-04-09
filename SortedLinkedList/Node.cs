using System;
using System.Reflection.Metadata;

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

        // public int CompareTo(T? other)
        // {
        //     try
        //     {
        //         string A = Convert.ToString(this.Data);
        //         if (A == null) A = "";
        //         string B = Convert.ToString(this.Data);
        //         if (B == null) B = "";
        //         return A.CompareTo(B);
        //
        //     }
        //     catch
        //     {
        //         Console.WriteLine("Comparation Error");
        //         return -1;
        //     }
        // }

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
            //if(this.Data.CompareTo(other.Data))
            try
            {
                if (Convert.ToInt32(this.Data) < Convert.ToInt32(other.Data)) return true;
                return false;
            }
            catch
            {
                try
                {
                    if((Convert.ToString(this.Data) ?? " ").CompareTo(Convert.ToString(other.Data) ?? " ") <= 0) return true;
                    //Console.WriteLine("CANNOT COMPARE NODES");
                    return false;
                }
                catch
                {
                    Console.WriteLine("CANNOT COMPARE NODES");
                    return false;
                }
            }
            
            
        }
        
    }
}