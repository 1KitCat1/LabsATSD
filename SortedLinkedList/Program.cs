using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new LinkedList<int>(5);
            for (int i = 0; i < 8; i++)
            {
                List.Add(i);
            }
            List.Print();
            List.Delete(3);
            List.AppendHead(0);
            List.Print();
            
            Console.Read();
        }
    }
}