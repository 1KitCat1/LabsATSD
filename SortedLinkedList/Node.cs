namespace SortedLinkedList
{
    public class Node<T>
    {
        private T data;
        private Node<T> next = null;
        public T Data
        {
            get{return data}
            set
            {
                if (value != null) data = value;
            }
        }
    }
}