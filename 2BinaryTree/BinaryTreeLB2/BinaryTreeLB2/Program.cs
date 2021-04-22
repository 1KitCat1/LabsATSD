using System;

namespace BinaryTreeLB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(8);
            tree.Add(1);
            foreach (var item in tree.Preorder())
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}