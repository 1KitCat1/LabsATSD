using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new LinkedList<int>(10);
            for (int i = 8; i > 0; i--)
            {
                List.InsertSorted(i);
            }
            List.Print();
            List.Delete(3);
            List.AppendHead(0);
            List.Print();
            
            Console.Read();
        }
    }
}