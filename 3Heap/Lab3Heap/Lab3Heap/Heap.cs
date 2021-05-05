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
    }
}