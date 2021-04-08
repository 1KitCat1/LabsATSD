using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>(10);
            for (int i = 8; i > 0; i--)
            {
                list.InsertSorted(i);
            }
            list.Print();
            list.Delete(3);
            list.Print();
            list.InsertSorted(3);
            list.Print();
            list.AppendHead(1);
            //List.DeleteDuplicated();
            list.Print();
            //list.Reverse();
            list.Print();
            Console.Read();
        }
    }
}