using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace BinaryTreeLB2
{
    public class BinaryTree<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public BinaryTree(Node<T> root)
        {
            Root = root;
            Count = 1;
        }
        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }
        //Binary tree node add. For balanced tree use InsertBalanced
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
        //Insert Balanced
        public void InsertBalanced(T data)
        {
            var node = new Node<T>(data);
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Count++;
            InsertBalanced(Root, node);
        }

        public Node<T> InsertBalanced(Node<T> currentNode, Node<T> insertionNode)
        {
            if (currentNode == null)
            {
                currentNode = insertionNode;
                return currentNode;
            }
            if (insertionNode.Data.CompareTo(currentNode.Data) < 0)
            {
                currentNode.Left = InsertBalanced(currentNode.Left, insertionNode);
                currentNode = BalanceTree(currentNode);
            }
            else if (insertionNode.Data.CompareTo(currentNode.Data) > 0)
            {
                currentNode.Right = InsertBalanced(currentNode.Right, insertionNode);
                currentNode = BalanceTree(currentNode);
            }
            return currentNode;
        }
        //Insert Balanced ends
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

        public void PrintSorted()
        {
            var list = Inorder();
            Console.WriteLine("Print in ascending order (inorder): ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Print in descending order: ");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        //
        
        //Node rotations
        private Node<T> RotateR(Node<T> parent)
        {
            Node<T> current = parent.Right;
            parent.Right = current.Left;
            current.Left = parent;
            return current;
        }
        private Node<T> RotateL(Node<T> parent)
        {
            Node<T> current = parent.Left;
            parent.Left = current.Right;
            current.Right = parent;
            return current;
        }

        private Node<T> RotateRl(Node<T> parent)
        {
            Node<T> current = parent.Right;
            parent.Right = RotateL(current);
            return RotateR(parent);
        }
        
        private Node<T> RotateLr(Node<T> parent)
        {
            Node<T> current = parent.Left;
            parent.Left = RotateR(current);
            return RotateL(parent);
        }
        //Node rotation ends
        
        //Node balancing
        private int GetHeight(Node<T> current)
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.Left);
                int r = GetHeight(current.Right);
                height = Math.Max(l,r) + 1;
            }
            return height;
        }

        public bool IsBalanced()
        {
            if (Root == null) return true;
            return IsBalanced(Root);
        }

        public bool IsBalanced(Node<T> node)
        {
            if (node == null) return true;
            var balance = BalanceFactor(node);
            if (balance > -2 && balance < 2)
            {
                if (IsBalanced(node.Right) && IsBalanced(node.Left)) return true;
                else return false;
            }
            else return false;
        }
        private int BalanceFactor(Node<T> current)
        {
            int l = GetHeight(current.Left);
            int r = GetHeight(current.Right);
            int balanceFactor = l - r;
            return balanceFactor;
        }
        
        private Node<T> BalanceTree(Node<T> current)
        {
            int balanceFactor = BalanceFactor(current);
            if (balanceFactor > 1)
            {
                if (BalanceFactor(current.Left) > 0)
                {
                    current = RotateL(current);
                }
                else
                {
                    current = RotateLr(current);
                }
            }
            else if (balanceFactor < -1)
            {
                if (BalanceFactor(current.Right) > 0)
                {
                    current = RotateRl(current);
                }
                else
                {
                    current = RotateR(current);
                }
            }
            return current;
        }

        public BinaryTree<T> BalanceTreeBackup()
        {
            var list = Inorder();
            var tree = new BinaryTree<T>();
            while (list.Count > 0)
            {
                int ind = Count / 2;
                tree.Add(list[ind]);
                list.RemoveAt(ind);
            }

            return tree;
        }

        //
        //DeleteNode
        public void Remove(T data)
        {
            Root = Remove(Root, data);
        }
        private Node<T> Remove(Node<T> current, T data)
        {
            if (current == null)
            {
                return null;
            }
            if (data.CompareTo(current.Data) < 0)
            {
                current.Left = Remove(current.Left, data);
                if (BalanceFactor(current) == -2)
                {
                    if (BalanceFactor(current.Right) <= 0)
                    {
                        current = RotateR(current);
                    }
                    else
                    {
                        current = RotateRl(current);
                    }
                }
            }
            else if (data.CompareTo(current.Data) > 0)
            {
                current.Right = Remove(current.Right, data);
                if (BalanceFactor(current) == 2)
                {
                    if (BalanceFactor(current.Left) >= 0)
                    {
                        current = RotateL(current);
                    }
                    else
                    {
                        current = RotateLr(current);
                    }
                }
            }
            else
            {
                if (current.Right != null)
                {
                    Node<T> parent = current.Right;
                    while (parent.Left != null)
                    {
                        parent = parent.Left;
                    }
                    current.Data = parent.Data;
                    current.Right = Remove(current.Right, parent.Data);
                    if (BalanceFactor(current) == 2)
                    {
                        if (BalanceFactor(current.Left) >= 0)
                        {
                            current = RotateL(current);
                        }
                        else { current = RotateLr(current); }
                    }
                }
                else
                {   
                    return current.Left;
                }
            }
            return current;
        }
        public int CountNodeLeft()
        {
            return CountNodeLeft(Root.Left);
        }
        private int CountNodeLeft(Node<T> current)
        {
            if (current == null)
            {
                return 0;
            }
            return 1 + CountNodeLeft(current.Left) + CountNodeLeft(current.Right);
            
        }

        public int SumKeysRight()
        {
            return SumKeys(Root.Right);
        }
        private  int SumKeys(Node<T> root)
        {
            if (root == null) return 0;
            if (int.TryParse(root.Data.ToString(), out int val))
            {
                //Console.Write(val + " - ");
                return val + SumKeys(root.Right) + SumKeys(root.Left);
            }
           
            Console.WriteLine("Cannot parse node value to int");
            return -1;
            
        }
        public BinaryTree<T> DeleteEven()
        {
            var tempTree = new BinaryTree<T>();
            var list = Inorder();
            foreach (var item in list)
            {
                if (int.TryParse(item.ToString(), out int val))
                {
                    if(val % 2 != 0)tempTree.Add(item);
                }
                else
                {
                    Console.WriteLine("Tree is not int. Cannot delete even");
                    return tempTree;
                }
            }

            return tempTree;
        }
        public int FindMiddle()
        {
            var list = Inorder();
            int minDif = 9999;
            int minVal = 10000;
            int maxVal = -10000;

            foreach(var item in list)
            {
                if (int.TryParse(item.ToString(), out int val))
                {
                    minVal = Math.Min(minVal, val);
                    maxVal = Math.Max(maxVal, val);
                }
                else
                {
                    Console.WriteLine("Cannot parse to int");
                    return -9999;
                }
            }
            foreach(var item in list)
            {
                if (int.TryParse(item.ToString(), out int val))
                {
                    if (Math.Abs((maxVal + minVal) / 2 - val) < Math.Abs((maxVal + minVal) / 2 - minDif))
                    {
                        minDif = val;
                    }
                }
                else
                {
                    Console.WriteLine("Cannot parse to int");
                    return -9999;
                }
            }

            return minDif;
        }

        public BinaryTree<T> DeleteDuplicates()
        {
            var list = Preorder();
            var newList = new List<T>();
            foreach (var item in list)
            {
                if (!newList.Contains(item))
                {
                    newList.Add(item);
                }
            }

            var newTree = new BinaryTree<T>();
            foreach (var item in list)
            {
                newTree.Add(item);
            }

            return newTree;
        }

        public T FindSecondLargest()
        {
            var list = Inorder();
            if (list.Count < 2) return default(T);
            return list[list.Count - 2];
        }

        // public BinaryTree<T> CopyBBST()
        // {
        //     var newTree = new BinaryTree<T>();
        //     newTree.Root = new Node<T>(Root.Data);
        //     var list = Inorder();
        //     while (list.Count > 0)
        //     {
        //         int ind = list.Count / 2;
        //         newTree.Add(list[ind]);
        //         list.RemoveAt(ind);
        //     }
        //
        //     return newTree;
        // }
        public BinaryTree<T> CopyBBST()
        {
            BinaryTree<T> tree = new BinaryTree<T>(this.CopyTree(Root));
            return tree;
        }
        private Node<T> CopyTree(Node<T> root)
        {
            if (root == null)
            {
                return null;
            }
            var temp = new Node<T>(root.Data);
            temp.Left = CopyTree(root.Left);
            temp.Right = CopyTree(root.Right);
            return temp;
        }

        public void InsertBBST(BinaryTree<T> secondTree)
        {
            var list = secondTree.Inorder();
            foreach (var item in list)
            {
                InsertBalanced(item);
            }
        }

        public bool ContainsBBST(BinaryTree<T> secondTree)
        {
            var list = Inorder();
            var list2 = secondTree.Inorder();
            for (int i = 0; i < list2.Count; i++)
            {
                if (!list.Contains(list2[i])) return false;
            }

            return true;
        }

        public bool IsEqual(BinaryTree<T> secondTree)
        {
            var list1 = Inorder();
            var list2 = secondTree.Inorder();
            if (list1.Count != list2.Count) return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i])) return false;
            }

            return true;
        }

        public  BinaryTree<T> SymmetricalBBST()
        {
            var sTree = new BinaryTree<T>(SymmetricalBBST(Root));
            return sTree;
        }
  
        private  Node<T> SymmetricalBBST(Node<T> root)
        {
            if (root == null)
            {
                return null;
            }
           
            Node<T> node = new Node<T>(root.Data);
            node.Right = SymmetricalBBST(root.Left);
            node.Left = SymmetricalBBST(root.Right);
            return node;
        }

        public T FatherNode(T data)
        {
            if (Root.Data.Equals(data))
            {
                Console.WriteLine("Value found in root, returned default value");
                return default(T);
            }

            return FatherNode(data, Root);
        }

        private T FatherNode(T data, Node<T> father)
        {
            if (father.Left != null && father.Left.Data.Equals(data)) return father.Data;
            if (father.Right != null && father.Right.Data.Equals(data)) return father.Data;

            if (father.Data.CompareTo(data) > 0)
            {
                if (father.Left == null)
                {
                    Console.WriteLine("Root has not been found");
                    return default(T);
                }
                return FatherNode(data, father.Left);
            }
            else
            {
                if (father.Right == null)
                {
                    Console.WriteLine("Root has not been found");
                    return default(T);
                }
                return FatherNode(data, father.Right);
            }
            
        }
    }
}