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
            Console.WriteLine("Inserts all keys of BBST2 into a BBST1. Result is BBST1 which is balanced");
            var tree2 = new BinaryTree<int>();
            tree2.Add(15);
            tree2.Add(4);
            tree2.Add(11);
            tree2.Add(17);
            tree2.PrintInorder();
            tree.InsertBBST(tree2);
            tree.PrintInorder();
            tree.PrintInorder();
            //Task 10
            Console.WriteLine("Determines if all keys of BBST2 are contained in BBST1");
            var tree10 = new BinaryTree<int>();
            tree10.Add(5);
            tree10.Add(6);
            tree10.Add(3);
            Console.WriteLine(tree.ContainsBBST(tree10));
            //Task 11
            Console.WriteLine("Returns true if the calling object is a balanced binary search tree, otherwise false");
            Console.WriteLine(tree.IsBalanced());
            //Task 12
            Console.WriteLine("Returns true if two BBSTs are equal ");
            Console.WriteLine("Comparing tree and its copy: ");
            Console.WriteLine(tree.IsEqual(tree.CopyBBST()));
            Console.WriteLine("Comparing tree and another tree: ");
            Console.WriteLine(tree.IsEqual(tree10));
            //Task 13
            Console.WriteLine("Creates and returns a new BBST which is symmetrical to the original one");
            var symmetricalTree = tree.SymmetricalBBST();
            symmetricalTree.PrintInorder();
            //Task 14
            

        }
    }
}