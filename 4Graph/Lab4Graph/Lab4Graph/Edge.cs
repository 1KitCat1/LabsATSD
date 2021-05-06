using System;

namespace Lab4Graph
{
    public class Edge<T>
        where T: IComparable
    {
        public int Vert1 { get; protected set; }
        public int Vert2 { get; protected set; }
        public int Weight { get; protected set; }
        
    }
}