using System;

namespace BinaryTreeLB2
{
    public class Node<T> : IComparable
        where T: IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Node<T> other)
            {
                return Data.CompareTo(other.Data);
            }
            else
            {
                Console.WriteLine("Cannot compare properly");
                return -1;
            }
        }
    }
}