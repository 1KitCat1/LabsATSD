using System;

namespace Lab3Heap {
    class Program {
        static void Main(string[] args)
        {
            var heap = new Heap(10, 20, 15, 12, 40, 25, 18);
            heap.Heapify();
            heap.Print();
        }
    }
}
