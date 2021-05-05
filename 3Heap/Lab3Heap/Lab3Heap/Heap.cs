using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Lab3Heap
{
    public class Heap
    {
        private int length;
        private int[] array;
        

        public Heap(int length)
        {
            this.length = 0;
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
            if(parent * 2 + 2 < length) return parent * 2 + 2;
            return -1;
        }
        public int LeftChildren(int parent)
        {
            
            if(parent * 2 + 1 < length) return parent * 2 + 1;
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
            RecursiveHeapify(length - 1);
        }
        
        public void SiftUp(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Array is full");
                return;
            }

            int position = length;
            array[length++] = item;
            
            while (position > 0)
            {
                int parent = position / 2;
                if (array[position] < array[parent])
                {
                    int temp = array[position];
                    array[position] = array[parent];
                    array[parent] = temp;
                }
                else break;

                position = parent;
            }
        }

        public void SiftDown()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Heap is empty");
                return;
            }

            array[0] = array[--length];
            SiftDown(0);
        }

        private void SiftDown(int position)
        {
            if (LeftChildren(position) == -1 && RightChildren(position) == -1)
            {
                return;
            }

            if (RightChildren(position) == -1 || array[RightChildren(position)] > array[LeftChildren(position)])
            {
                if (array[LeftChildren(position)] < array[position])
                {
                    var temp = array[position];
                    array[position] = array[LeftChildren(position)];
                    array[LeftChildren(position)] = temp;
                    SiftDown(LeftChildren(position));
                }
            }
            else if(array[RightChildren(position)] < array[position])
            {
                var temp = array[position];
                array[position] = array[LeftChildren(position)];
                array[LeftChildren(position)] = temp;
                SiftDown(LeftChildren(position));
            }
        }

        public int DeleteTop()
        {
            int rez = array[0];
            SiftDown();
            return rez;
        }
        
    }
}