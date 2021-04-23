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
            Console.WriteLine("Count the number of left son nodes: ");
            Console.WriteLine(tree.CountNodeLeft());
            //Task 3 ONLY FOR INT
            Console.WriteLine("Finds the sum of keys in right son nodes: ");
            Console.WriteLine(tree.SumKeysRight());
            //Task 4 ONLY FOR INT
            Console.WriteLine("Deletes all even keys: ");
            var tempTree = tree.DeleteEven();
            tempTree.PrintInorder();
            //Task 5 ONLY FOR INT
            Console.WriteLine("Returns the tree key which is the nearest to the middle: ");
            Console.WriteLine(tree.FindMiddle());
            //Task 6 
            Console.WriteLine("Deletes all duplicate values: ");
            var noDuplicatesTree = tree.DeleteDuplicates();
            noDuplicatesTree.PrintInorder();
            //Task 7
            Console.WriteLine("Returns the second largest key: ");
            Console.WriteLine(tree.FindSecondLargest());
            //Task 8
            Console.WriteLine("Returns the copy of a binary tree: ");
            var copyTree = tree.CopyBBST();
            copyTree.PrintInorder();
            //Task 9
            Console.WriteLine("Inserts al keys of BBST2 into a BBST1. Result is BBST1 which is balanced");
            var tree2 = new BinaryTree<int>();
            tree2.InsertBalanced(15);
            tree2.InsertBalanced(4);
            tree2.InsertBalanced(11);
            tree2.InsertBalanced(6);
            tree2.PrintInorder();
            
        }
    }
}