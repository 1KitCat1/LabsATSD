using System;

namespace BinaryTreeLB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.InsertBalanced(5);
            tree.InsertBalanced(3);
            tree.InsertBalanced(7);
            tree.InsertBalanced(1);
            tree.InsertBalanced(2);
            tree.InsertBalanced(8);
            tree.InsertBalanced(6);
            tree.InsertBalanced(9);

            tree.PrintInorder();
            tree.PrintPostorder();
            tree.PrintPreorder();
            //Task 1
            tree.PrintSorted();
            //Task 2
            Console.WriteLine(tree.CountNodeLeft());;
            
            Console.WriteLine(tree.Size());
        }
    }
}