using System;

namespace Lab3Heap
{
    public class Heap
    {
        private int length;
        private int[] array;
        

        public Heap(int length)
        {
            this.length = length;
            array = new int[length];
        }

        public Heap(params int[] elements)
        {
            array = elements;
            length = elements.Length;
        }

        public void Print()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public bool IsFull()
        {
            return length == array.Length;
        }

        public int Size()
        {
            return length;
        }

        public int RightChildren(int parent)
        {
            return parent * 2 + 1;
        }
        public void Heapify()
        {
            for (int i = length - 1; i > 0; i++)
            {
                
            }
        }
    }
}