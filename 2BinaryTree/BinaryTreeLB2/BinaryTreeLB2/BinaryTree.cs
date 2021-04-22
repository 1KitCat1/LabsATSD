using System;
using System.Collections.Generic;

namespace BinaryTreeLB2
{
    public class BinaryTree<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Root.Add(data);
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

    }
}