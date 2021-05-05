using System;
using System.Data;

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
            if(parent * 2 + 1 < length) return parent * 2 + 1;
            return -1;
        }
        public int LeftChildren(int parent)
        {
            if(parent * 2 < length) return parent * 2;
            return -1;
        }

        private void RecursiveHeapify(int parent)
        {
            if (parent < 0) return;
            if (LeftChildren(parent) != -1)
            {
                if (array[LeftChildren(parent)] < array[parent])
                {
                    int temp = array[parent];
                    array[parent] = array[LeftChildren(parent)];
                    array[LeftChildren(parent)] = temp;
                    RecursiveHeapify(LeftChildren(parent));
                }
            }
            if (RightChildren(parent) != -1)
            {
                if (array[RightChildren(parent)] < array[parent])
                {
                    int temp = array[parent];
                    array[parent] = array[RightChildren(parent)];
                    array[RightChildren(parent)] = temp;
                    RecursiveHeapify(RightChildren(parent));
                }
            }
            RecursiveHeapify(parent - 1);
        }
        public void Heapify()
        {
            RecursiveHeapify(length-1);
        }
    }
}