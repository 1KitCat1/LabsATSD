using System;

namespace Lab3Heap {
    class Program {
        static void Main(string[] args)
        {
            var heap = new Heap(5);
            heap.SiftUp(10);
            heap.SiftUp(8);
            heap.SiftUp(16);
            heap.SiftUp(13);
            heap.SiftUp(9);

            heap.Print();
            heap.SiftDown();
            heap.Print();
            heap.SiftDown();
            heap.SiftDown();
            heap.Print();
            
        }
    }
}
