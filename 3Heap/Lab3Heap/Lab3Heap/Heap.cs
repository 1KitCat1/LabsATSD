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
    }
}