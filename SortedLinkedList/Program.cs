using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>(0);
            for (int i = 0; i < 8; i++)
            {
                list.InsertSorted(i);
            }
            list.Print();
            list.Delete(3);
            list.Print();
            list.InsertSorted(3);
            //list.InsertSorted(7);
            list.InsertSorted(8);
            list.Print();
            //list.AppendHead(1);
            //List.DeleteDuplicated();
            list.Print();
            //list.Reverse();
            list.Print();
            
            var list2 = new LinkedList<string>("abc");
            list2.InsertSorted("zce");
            list2.InsertSorted("cde");
            list2.Print();
            Console.Read();

        }
    }
}