namespace SortedLinkedList
{
    public class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data;}
            set
            {
                if (value != null) data = value;
            }
        }
        public Node<T> Next { get; set; }
        //constructor
        public Node(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}