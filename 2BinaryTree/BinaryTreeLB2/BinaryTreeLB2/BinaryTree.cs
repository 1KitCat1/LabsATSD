﻿using System;
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
        //PREORDER
        public List<T> Preorder()
        {
            var list = new List<T>();
            if (Root == null) return new List<T>();
            return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;
        }
        //
        
        //POSTORDER
        public List<T> Postorder()
        {
            var list = new List<T>();
            if (Root == null) return new List<T>();
            return Postorder(Root);
        }

        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }
                list.Add(node.Data);
            }

            return list;
        }
        //

    }
}