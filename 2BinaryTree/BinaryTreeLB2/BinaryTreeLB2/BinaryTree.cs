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

            Count += 1;
            Root.Add(data);
        }

        public int Size()
        {
            return Count;
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

        public void PrintPreorder()
        {
            Console.WriteLine("Preorder: ");
            foreach (var item in this.Preorder())
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
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
        public void PrintPostorder()
        {
            Console.WriteLine("Postorder: ");
            foreach (var item in this.Postorder())
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
        //
        
        //INORDER
        public List<T> Inorder()
        {
            var list = new List<T>();
            if (Root == null) return new List<T>();
            return Inorder(Root);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
                
            }

            return list;
        }
        public void PrintInorder()
        {
            Console.WriteLine("Inorder: ");
            foreach (var item in this.Inorder())
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
        //
        
        private Node<T> RotateRR(Node<T> parent)
        {
            Node<T> current = parent.Right;
            parent.Right = current.Left;
            current.Left = parent;
            return current;
        }
    }
}