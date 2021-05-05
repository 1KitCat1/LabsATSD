using System;

namespace Lab3Heap
{
    public class Heap<T>
        where T : IComparable
    {
        private int length;
        private T[] array;

        public Heap(int length)
        {
            this.length = length;
            array = new T[length];
        }
    }
}