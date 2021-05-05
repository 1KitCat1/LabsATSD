using System;

namespace Lab3Heap {
    class Program {
        public void HeapSort(int[] array)
        {
            var heap = new Heap(array.Length);
            for(int i = 0; i < array.Length; i++) heap.SiftUp(array[i]);
            for (int i = 0; i < array.Length; i++)
            {
                
            }

            
        }
        static void Main(string[] args)
        {
            var heap = new Heap(10);
            heap.SiftUp(10);
            heap.SiftUp(20);
            heap.SiftUp(15);
            heap.SiftUp(12);
            heap.SiftUp(40);
            heap.SiftUp(25);
            heap.SiftUp(18);
            
            heap.Print();
            heap.SiftDown();
            heap.Print();
            heap.SiftDown();
            heap.Print();
            heap.SiftDown();
            heap.Print();
            
        }
    }
}
