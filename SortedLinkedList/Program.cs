﻿using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new LinkedList<int>(5);
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Print();
            List.Delete(3);
            foreach (var item in List)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}