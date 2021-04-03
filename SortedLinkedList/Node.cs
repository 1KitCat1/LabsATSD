namespace SortedLinkedList
{
    public class Node<T>
    {
        private T data;
        public T Data
        {
            get{return data}
            set
            {
                if (value != null) data = value;
            }
        }

        public Node<T> Next { get; set; }
        
    }
}